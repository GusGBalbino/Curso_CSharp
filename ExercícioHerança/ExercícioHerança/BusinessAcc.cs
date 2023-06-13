
namespace ExercícioHerança
{
    class BusinessAcc : Account //Herdando os valores de Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcc() 
        { 
        }

        public BusinessAcc(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) //Reutilizando as atribuições
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }

        }

    }
}
