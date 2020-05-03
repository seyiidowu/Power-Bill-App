namespace PowerBill
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picPowerCompany = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.lblkWh1Prompt = new System.Windows.Forms.Label();
            this.lblkWh2Prompt = new System.Windows.Forms.Label();
            this.txtkWh1 = new System.Windows.Forms.TextBox();
            this.txtkWh2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.lstCustomerData = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalIchg = new System.Windows.Forms.Label();
            this.lblTotalCChg = new System.Windows.Forms.Label();
            this.lblTotalRChg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumCust = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerCompany)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPowerCompany
            // 
            this.picPowerCompany.Image = ((System.Drawing.Image)(resources.GetObject("picPowerCompany.Image")));
            this.picPowerCompany.Location = new System.Drawing.Point(45, 24);
            this.picPowerCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPowerCompany.Name = "picPowerCompany";
            this.picPowerCompany.Size = new System.Drawing.Size(438, 231);
            this.picPowerCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPowerCompany.TabIndex = 0;
            this.picPowerCompany.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Location = new System.Drawing.Point(494, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select customer type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(261, 41);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(92, 24);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(145, 41);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(110, 24);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Location = new System.Drawing.Point(33, 41);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(106, 24);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // lblkWh1Prompt
            // 
            this.lblkWh1Prompt.AutoSize = true;
            this.lblkWh1Prompt.Location = new System.Drawing.Point(495, 226);
            this.lblkWh1Prompt.Name = "lblkWh1Prompt";
            this.lblkWh1Prompt.Size = new System.Drawing.Size(87, 20);
            this.lblkWh1Prompt.TabIndex = 2;
            this.lblkWh1Prompt.Text = "Used khW:";
            // 
            // lblkWh2Prompt
            // 
            this.lblkWh2Prompt.AutoSize = true;
            this.lblkWh2Prompt.Location = new System.Drawing.Point(495, 268);
            this.lblkWh2Prompt.Name = "lblkWh2Prompt";
            this.lblkWh2Prompt.Size = new System.Drawing.Size(111, 20);
            this.lblkWh2Prompt.TabIndex = 3;
            this.lblkWh2Prompt.Text = "Off-peak khW:";
            // 
            // txtkWh1
            // 
            this.txtkWh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkWh1.Location = new System.Drawing.Point(630, 220);
            this.txtkWh1.Name = "txtkWh1";
            this.txtkWh1.Size = new System.Drawing.Size(132, 29);
            this.txtkWh1.TabIndex = 4;
            this.txtkWh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkWh2
            // 
            this.txtkWh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkWh2.Location = new System.Drawing.Point(630, 262);
            this.txtkWh2.Name = "txtkWh2";
            this.txtkWh2.Size = new System.Drawing.Size(132, 29);
            this.txtkWh2.TabIndex = 5;
            this.txtkWh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(565, 394);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(184, 39);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(852, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(978, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer Charge:";
            // 
            // lblCharge
            // 
            this.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(646, 309);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(156, 32);
            this.lblCharge.TabIndex = 10;
            this.lblCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(490, 36);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(124, 20);
            this.lblCustName.TabIndex = 11;
            this.lblCustName.Text = "Customer Name";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(630, 30);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(202, 29);
            this.txtCustName.TabIndex = 12;
            this.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Account Number";
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNum.Location = new System.Drawing.Point(630, 82);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(159, 29);
            this.txtAcctNum.TabIndex = 14;
            this.txtAcctNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstCustomerData
            // 
            this.lstCustomerData.FormattingEnabled = true;
            this.lstCustomerData.ItemHeight = 20;
            this.lstCustomerData.Location = new System.Drawing.Point(886, 28);
            this.lstCustomerData.Name = "lstCustomerData";
            this.lstCustomerData.Size = new System.Drawing.Size(212, 324);
            this.lstCustomerData.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(784, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTotalIchg);
            this.groupBox2.Controls.Add(this.lblTotalCChg);
            this.groupBox2.Controls.Add(this.lblTotalRChg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTotalCharges);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblNumCust);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 172);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Ind. Charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Comm. Charges";
            // 
            // lblTotalIchg
            // 
            this.lblTotalIchg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalIchg.Location = new System.Drawing.Point(195, 142);
            this.lblTotalIchg.Name = "lblTotalIchg";
            this.lblTotalIchg.Size = new System.Drawing.Size(120, 18);
            this.lblTotalIchg.TabIndex = 10;
            this.lblTotalIchg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalCChg
            // 
            this.lblTotalCChg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCChg.Location = new System.Drawing.Point(195, 105);
            this.lblTotalCChg.Name = "lblTotalCChg";
            this.lblTotalCChg.Size = new System.Drawing.Size(120, 18);
            this.lblTotalCChg.TabIndex = 9;
            this.lblTotalCChg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalRChg
            // 
            this.lblTotalRChg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRChg.Location = new System.Drawing.Point(195, 70);
            this.lblTotalRChg.Name = "lblTotalRChg";
            this.lblTotalRChg.Size = new System.Drawing.Size(120, 18);
            this.lblTotalRChg.TabIndex = 8;
            this.lblTotalRChg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Res. Charges";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCharges.Location = new System.Drawing.Point(337, 29);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(79, 18);
            this.lblTotalCharges.TabIndex = 6;
            this.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Charges";
            // 
            // lblNumCust
            // 
            this.lblNumCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumCust.Location = new System.Drawing.Point(133, 30);
            this.lblNumCust.Name = "lblNumCust";
            this.lblNumCust.Size = new System.Drawing.Size(79, 18);
            this.lblNumCust.TabIndex = 4;
            this.lblNumCust.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "# of Customers";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCustomerData);
            this.Controls.Add(this.txtAcctNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtkWh2);
            this.Controls.Add(this.txtkWh1);
            this.Controls.Add(this.lblkWh2Prompt);
            this.Controls.Add(this.lblkWh1Prompt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPowerCompany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPowerCompany)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPowerCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Label lblkWh1Prompt;
        private System.Windows.Forms.Label lblkWh2Prompt;
        private System.Windows.Forms.TextBox txtkWh1;
        private System.Windows.Forms.TextBox txtkWh2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.ListBox lstCustomerData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalIchg;
        private System.Windows.Forms.Label lblTotalCChg;
        private System.Windows.Forms.Label lblTotalRChg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

