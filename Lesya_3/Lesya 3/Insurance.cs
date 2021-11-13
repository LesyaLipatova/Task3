using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesya_3
{
    public class Insurance
    {
        public string name;
        public int insurance_price;
        public double payment;
        public int degree_of_risk;

        public Insurance(string name, int degree_of_risk)
        {
            this.name = name;
            this.degree_of_risk = degree_of_risk;
        }
        
        public string get_name()
        {
            return name;
        }
        public int get_insurance_price()
        {
            return insurance_price;
        }
        public double get_payment()
        {
            return payment;
        }
        public int get_degree_of_risk()
        {
            return degree_of_risk;
        }
    }

}
