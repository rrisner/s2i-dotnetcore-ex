
using System.Collections;

public class MortgageCalculator 
{
    double interestRate = 0;
    double principal = 0;
    double monthlyPayment = 0;

    Hashtable extraPayments = new Hashtable();

    public MortgageCalculator() {}
    public MortgageCalculator(double principal, double interestRate, double monthlyPayment)
    {
        this.principal = principal;
        this.interestRate = interestRate;
        this.monthlyPayment = monthlyPayment;
    }

    public void addExtraPayment(int month, double amount)
    {
        extraPayments.Add(month, amount);
    }

    public (double, int) sumTotalCosts()
    {
        double sum = 0;
        double residual = principal;
        double payment = monthlyPayment;
        int counter = 0;
        int repeatLimit = 100000;

        while(residual > 0 && counter++ < repeatLimit)
        {
            residual *= (1 + interestRate);
            payment = residual <= monthlyPayment ? monthlyPayment : residual;
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
        double residual = principal;
        double payment = monthlyPayment;
        int counter = 0;
        int repeatLimit = 100000;

        while(residual > 0 && counter++ < repeatLimit)
        {
            residual *= (1 + interestRate);
            if (extraPayments.Contains(counter))
            {
                residual -= extraPayments[counter];
                sum += extraPayments[counter];
            }
            payment = residual <= monthlyPayment ? monthlyPayment : residual;
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
