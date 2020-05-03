using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBill
{
    public class CustomerData
    {
        //public data
        public string Name { get; set; }
        public int AcctNo { get; set; }
        public string CustomerType { get; set; }
        public decimal Charge { get; set; }


        public CustomerData(string m = "unknown", string n = "type", int p = 0, decimal q = 0)
        {
            Name = m; // auto-implement property
            CustomerType = n;
            AcctNo = p; // use of property enforces validation
            Charge = q;
        }



        public static decimal ResidentialCharge(int kWh)
        {
            const decimal BASE_CHARGE = 6;
            const decimal CHARGE_PER_kWh = 0.052m;
            decimal charge = BASE_CHARGE + kWh * CHARGE_PER_kWh;
            return charge;
        }

        // calculate charge for commercial customer
        public static decimal CommercialCharge(int kWh)
        {
            const decimal BASE_CHARGE = 60;
            const int THRESHOLD = 1000;
            const decimal CHARGE_PER_kWh = 0.045m;
            decimal charge = BASE_CHARGE;
            if (kWh > THRESHOLD)
                charge += (kWh - THRESHOLD) * CHARGE_PER_kWh;
            return charge;
        }

        // calculate charge for industrial customer
        public static decimal IndustrialCharge(int peakKWh, int offPeakKWh)
        {
            const decimal PEAK_BASE_CHARGE = 76;
            const decimal OFF_PEAK_BASE_CHARGE = 40;
            const int THRESHOLD = 1000;
            const decimal PEAK_CHARGE_PER_kWh = 0.065m;
            const decimal OFF_PEAK_CHARGE_PER_kWh = 0.028m;
            decimal charge, peakCharge, offPeakCharge;
            // calculate charge for peak kWh
            peakCharge = PEAK_BASE_CHARGE;
            if (peakKWh > THRESHOLD)
                peakCharge += (peakKWh - THRESHOLD) * PEAK_CHARGE_PER_kWh;
            // calculate charge for off-peak kWh
            offPeakCharge = OFF_PEAK_BASE_CHARGE;
            if (offPeakKWh > THRESHOLD)
                offPeakCharge += (offPeakKWh - THRESHOLD) * OFF_PEAK_CHARGE_PER_kWh;
            // add the two charges
            charge = peakCharge + offPeakCharge;
            return charge;
        }


        public override string ToString()
        {
            return "\n" + Name + "," +
                   CustomerType + "," + AcctNo.ToString()  + "," + Charge.ToString("c");
        }
    }
}
