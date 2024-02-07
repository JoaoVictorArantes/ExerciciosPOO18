using ExerciciosPOO18.Entities.Exceptions;

namespace ExerciciosPOO18.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void deposit(double Amount)
        {
            Balance += Amount;
        }
        public void Withdraw(double Amount)
        {
            if (Balance < Amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Amount > WithdrawLimit)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= Amount;
        }
    }
}
