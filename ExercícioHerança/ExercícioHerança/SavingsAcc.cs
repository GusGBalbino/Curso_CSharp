namespace ExercícioHerança
{
    class SavingsAcc : Account
    {
        public double InterestRate { get; set; }

        public SavingsAcc()
        {
        }

        public SavingsAcc(int number, string holder, double balance, double interestRate) 
            :base(number, holder, balance)
        {
            InterestRate = interestRate;   
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
