using System.Collections;
using System.Collections.Generic;

namespace app.Models
{
    public class Mortgage
    {
        public static List<string> examples = new List<string>();
        public Mortgage()
        {
            Principal = 0;
            InterestRate = 0;
            MonthlyPayment = 0;
            ExtraPayment = 0;
            ExtraPaymentMonth = 0;
        }

        public double Principal {get;set;}
        public double InterestRate {get;set;}
        public double MonthlyPayment {get;set;}
        public double ExtraPayment {get;set;}
        public int ExtraPaymentMonth {get;set;}
    }
}

