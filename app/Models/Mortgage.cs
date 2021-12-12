using System.Collections;
using System.Collections.Generic;

namespace app.Models
{
    public class Mortgage
    {
        //public static List<string> examples = new List<string>();
        public static List<MortgageCalculator> userExamples = new List<MortgageCalculator>();
        public Mortgage()
        {
            Principal = 0.ToString();
            InterestRate = 0.ToString();
            MonthlyPayment = 0.ToString();
            ExtraPayment = 0.ToString();
            ExtraPaymentMonth = 0.ToString();
        }

        public string Principal {get;set;}
        public string InterestRate {get;set;}
        public string MonthlyPayment {get;set;}
        public string ExtraPayment {get;set;}
        public string ExtraPaymentMonth {get;set;}
    }
}

