
// Purpose - This application collects name, account number and energy about of the customer
// and in return calculates the bill charge. and also store the data
//
// Written on 21/04/2020
//
// By Seyi Idowu

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBill
{
    public partial class frmMain : Form
    {
        const string path = "customers.txt"; // text stores data in bin/Debug folder of the project
        List<CustomerData> customers = new List<CustomerData>(); // start an empty list
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) // this block helps to load customers.txt when the form loads
        { 
            FileStream fs;
            StreamReader sr = null;
            string line; // for reading
            string[] fields; // line broken into fields
            CustomerData cust;
            string name; //customer name
            int acctNo; //customer account num
            string customerType; // type if residential, commercial or industrial
            decimal charge;

            if (radResidential.Checked)
            {
                customerType = "R";
            }
            else if (radCommercial.Checked)
            {
                customerType = "C";
            }
            else
            {
                customerType = "I";
            }

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                // read data
                while (!sr.EndOfStream) // while there are still products in the file
                {
                    line = sr.ReadLine(); // read next line
                    fields = line.Split(','); // CSV file
                    name = fields[0];
                    customerType = fields[1];
                    acctNo = Convert.ToInt32(fields[2]);
                    charge = Convert.ToDecimal(fields[3]);
                    cust = new CustomerData(name, customerType, acctNo, charge);
                    customers.Add(cust);
                }
                DisplayCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading products from file: " +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }

        // user select Residential
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            HideSecondInput();
        }

        // user selects Commercial
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            HideSecondInput();
        }

        // user selects Industrial
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            ShowSecondInput();
        }

        // hide second input prompt and txt box; 
        // adjust prompt for first input: generic kWh
        private void HideSecondInput()
        {
            lblkWh1Prompt.Text = "Used kWh:";
            lblkWh2Prompt.Visible = false;
            txtkWh2.Visible = false;
            txtCustName.Focus(); // focus on first input box

        }

        // hide second input prompt and txt box; 
        // adjust prompt for first input: peak kWh
        private void ShowSecondInput()
        {
            lblkWh1Prompt.Text = "Peak kWh:";
            lblkWh2Prompt.Visible = true;
            txtkWh2.Visible = true;
            txtCustName.Focus(); // focus on first input box
        }



        // calculate customer charge
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int kWh = 0, peakKWh = 0, offPeaKWh = 0;
            decimal chargeAmt=0;
            if (radResidential.Checked)
            {
                if (Validator.IsPresent(txtkWh1, "kWh") &&
                   Validator.IsNonNegativeInteger(txtkWh1, "kWh"))
                {
                    kWh = Convert.ToInt32(txtkWh1.Text);
                    chargeAmt = CustomerData.ResidentialCharge(kWh);
                }
            }
            else if (radCommercial.Checked)
            {
                if (Validator.IsPresent(txtkWh1, "Used kWh") &&
                   Validator.IsNonNegativeInteger(txtkWh1, "kWh"))
                {
                    kWh = Convert.ToInt32(txtkWh1.Text);
                    chargeAmt = CustomerData.CommercialCharge(kWh);
                }
            }
            else // must be industrial
            {
                if (Validator.IsPresent(txtkWh1, "Peak kWh") &&
                    Validator.IsNonNegativeInteger(txtkWh1, "Peak kWh") &&
                    Validator.IsPresent(txtkWh2, "Off-peak kWh") &&
                    Validator.IsNonNegativeInteger(txtkWh2, "Off-peak kWh"))
                {
                    peakKWh = Convert.ToInt32(txtkWh1.Text);
                    offPeaKWh = Convert.ToInt32(txtkWh2.Text);
                    chargeAmt = CustomerData.IndustrialCharge(peakKWh, offPeaKWh);
                }
            }
            // display charge
            lblCharge.Text = chargeAmt.ToString();
        }
        private void DisplayCustomers() // calculate the statistics, count, total, totals for each classes
        {
            // list box
            lstCustomerData.Items.Clear();
            foreach (CustomerData n in customers)
            {
                lstCustomerData.Items.Add(n);


                // statistics labels
                lblNumCust.Text = customers.Count.ToString();

                decimal totalCharge = CalculateTotalCharges();
                lblTotalCharges.Text = totalCharge.ToString("c");

                decimal totalPartRes = CalculateChargesRes();
                lblTotalRChg.Text = totalPartRes.ToString("c");

                decimal totalPartComm = CalculateChargesComm();
                lblTotalCChg.Text = totalPartComm.ToString("c");

                decimal totalPartInd = CalculateChargesInd();
                lblTotalIchg.Text = totalPartInd.ToString("c");
            }
        }
        // calculates total charges of all customer types
        private decimal CalculateTotalCharges()
        {
            decimal total = 0;
            foreach (CustomerData n in customers)
                total += n.Charge;
            return total;

        }

        // calculates total charges for residential customer types
        private decimal CalculateChargesRes()
        {
            decimal total = 0;

            foreach (CustomerData n in customers)
            {
                if (n.CustomerType == "R")
                {
                    total += n.Charge;
                }
            }
            return total;
        }

        // calculates total charges for commercial customer types
        private decimal CalculateChargesComm()
        {
            decimal total = 0;

            foreach (CustomerData n in customers)
            {
                if (n.CustomerType == "C")
                {
                    total += n.Charge;
                }
            }
            return total;
        }

        // calculates total charges for industrial customer types
        private decimal CalculateChargesInd()
        {
            decimal total = 0;

            foreach (CustomerData n in customers)
            {
                if (n.CustomerType == "I")
                {
                    total += n.Charge;
                }
            }
            return total;
        }

        // clear controls and make customer name selected
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustName.Text = "";
            txtAcctNum.Text = "";
            txtkWh1.Text = "";
            txtkWh1.Text = "";
            lblCharge.Text = "";
            radResidential.Checked = true;
            txtCustName.Focus();
        }

        //exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // add information to the list and save the list to customers.txt 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            int acctNo;
            string customerType;
            decimal charge;

            //validations
            if (Validator.IsPresent(txtCustName, "Name") && 
                Validator.IsPresent(txtAcctNum, "Accout Number") && 
                Validator.IsNonNegativeInteger(txtAcctNum, "Accout Number")&&
                Validator.IsPresentlbl(lblCharge, "Calculate Charge"))
            {
                // assign values to objects
                name = txtCustName.Text;
                acctNo = Convert.ToInt32(txtAcctNum.Text);
                charge = Convert.ToDecimal(lblCharge.Text);
                if (radResidential.Checked)
                {
                    customerType = "R";
                }
                else if (radCommercial.Checked)
                {
                    customerType = "C";
                }
                else
                {
                    customerType = "I";
                }
                CustomerData newCust = new CustomerData(name, customerType, acctNo, charge);

                // add new product to the list
                customers.Add(newCust);

                // and refresh display
                DisplayCustomers();


                FileStream fs;
                StreamWriter sw = null;
                string line;
                try
                {
                    // open file for writing
                    fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    // write all products to the file in form like:
                    foreach (CustomerData p in customers)
                    {
                        line = p.Name + "," + p.CustomerType + "," + p.AcctNo + "," + p.Charge; // CSV file
                        sw.WriteLine(line);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while writing products to file: " +
                        ex.Message, ex.GetType().ToString());
                }
                finally
                {
                    if (sw != null) sw.Close();
                }
                txtCustName.Focus();
            }
        }
    }
}
