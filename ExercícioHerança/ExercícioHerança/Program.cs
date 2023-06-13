using System;

namespace ExercícioHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Gustavo", 0.0);
            BusinessAcc bacc = new BusinessAcc(1002, "Yetz INC", 0.0, 1000.00 );

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAcc(1003, "Anna", 0.0, 200.00);
            Account acc3 = new SavingsAcc(1004, "Jorge", 0.0, 0.01);

            //DOWNCASTING (Operação insegura)

            BusinessAcc acc4 = (BusinessAcc) acc2;
            acc4.Loan(100.0);

            //BusinessAcc acc5 = (BussinessAcc)acc3; - Erro bcc to savings

            if(acc3 is BusinessAcc) //False
            {
                BusinessAcc acc5 = (BusinessAcc) acc3;
                acc5.Loan(100.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAcc) //True
            {
                SavingsAcc acc5 = (SavingsAcc) acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Updated!");
            }
            


        }
    }
}