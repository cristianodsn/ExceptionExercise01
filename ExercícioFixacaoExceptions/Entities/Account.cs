using ExercícioFixacaoExceptions.Entities.Exceptions;

namespace ExercícioFixacaoExceptions.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; protected set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {           
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainExceptions("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
