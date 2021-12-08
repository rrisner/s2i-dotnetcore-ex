

public class MortgageCalculator 
{
    double interestRate = 0;
    double principal = 0;
    double payment = 0;

    Hashtable extraPayments = new Hashtable();

    public MortgageCalculator() {}
    public MortgageCalculator(double principal, double interestRate, double monthlyPayment)
    {
        this.principal = principal;
        this.interestRate = interestRate;
        this.payment = monthlyPayment;
    }

    public void addExtraPayment(int month, double amount)
    {
        extraPayments.put(month, amount);
    }

    public (double, int) sumTotalCosts()
    {
        double sum = 0;
        double residual = principal;
        double payment = payment;
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
            return 999999999;
        }

        return sum, counter;
    }

    public (double, int) sumTotalCostsWithExtraPayments()
    {
        double sum = 0;
        double residual = principal;
        double payment = payment;
        int counter = 0;
        int repeatLimit = 100000;

        while(residual > 0 && counter++ < repeatLimit)
        {
            residual *= (1 + interestRate);
            if (extraPayments.Contains(counter))
            {
                residual -= extraPayments.get(counter);
                sum += extraPayments.get(counter);
            }
            payment = residual <= monthlyPayment ? monthlyPayment : residual;
            residual -= payment;
            sum += payment;
        }

        if (counter == repeatLimit) 
        {
            return 999999999;
        }

        return sum, counter;
    }


}
