
using System.Collections;

public class MortgageCalculator 
{
    public double InterestRate {get;set;} = 0;
    public double OriginalInterestRate {get;set;} = 0;
    public double Principal {get;set;} = 0;
    public double MonthlyPayment {get;set;} = 0;
    public int ExtraPaymentMonth {get;set;} = 0;
    public double ExtraPaymentAmount {get;set;} = 0;

    Hashtable extraPayments = new Hashtable();

    public MortgageCalculator() {}
    public MortgageCalculator(double Principal, double InterestRate, double MonthlyPayment)
    {
        InterestRate /= 100.0;
        this.Principal = Principal;
        this.OriginalInterestRate = InterestRate;
        this.InterestRate = InterestRate / 12.0;
        this.MonthlyPayment = MonthlyPayment;
    }

    public void addExtraPayment(int month, double amount)
    {
        extraPayments.Add(month, amount);
        ExtraPaymentMonth = month;
        ExtraPaymentAmount = amount;
    }

    public (double, int) sumTotalCosts()
    {
        double sum = 0;
        double residual = Principal;
        double payment = MonthlyPayment;
        int counter = 0;
        int repeatLimit = 100000;

        while(residual > 0 && counter++ < repeatLimit)
        {
            residual *= (1 + InterestRate);
            payment = residual >= MonthlyPayment ? MonthlyPayment : residual;
            residual -= payment;
            sum += payment;
        }

        if (counter == repeatLimit) 
        {
            return (999999999, counter);
        }

        return (sum, counter);
    }

    public (double, int) sumTotalCostsWithExtraPayments()
    {
        double sum = 0;
        double residual = Principal;
        double payment = MonthlyPayment;
        int counter = 0;
        int repeatLimit = 100000;

        while(residual > 0 && counter++ < repeatLimit)
        {
            residual *= (1 + InterestRate);
            if (extraPayments.Contains(counter))
            {
                residual -= (double)extraPayments[counter];
                sum += (double)extraPayments[counter];
            }
            payment = residual >= MonthlyPayment ? MonthlyPayment : residual;
            residual -= payment;
            sum += payment;
        }

        if (counter == repeatLimit) 
        {
            return (999999999, counter);
        }

        return (sum, counter);
    }


}
