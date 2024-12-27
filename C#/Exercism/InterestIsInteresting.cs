using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance){
            case < 0:
                return 3.213f;
                break;
            case < 1000:
                return 0.500f;
                break;
            case < 5000:
                return 1.621f;
                break;
            case >= 5000:
                return 2.475f;
                break;
        }
    }
    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance)/100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance){
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
