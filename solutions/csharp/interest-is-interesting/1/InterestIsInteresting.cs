static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0) return 3.213f;
        else if(balance >= 0 && balance < 1000) return 0.5f;
        else if(balance >= 1000 && balance < 5000) return 1.621f;
        else return 2.475f;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        float rate = InterestRate(balance);
        return balance * (decimal)(rate/100);
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return (decimal) balance + Interest(balance);
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int i = 0;
        while(balance < targetBalance){
            i++;
            balance = AnnualBalanceUpdate(balance);
        }
        return i;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}
