using System;

namespace Tema_5._2_Ex6
{
    public abstract class Account : IDepositable
    {

        private Costumer customer;
        private decimal balance;
        private decimal interestRate;
        private DateTime openDate;


        public Account(Costumer customer, decimal balance, decimal rate, DateTime openDate)
        {
            this.Client = customer;
            this.Balance = balance;
            this.InterestRate = rate;
            this.openDate = openDate;
        }


        public Costumer Client
        {
            get { return this.customer;}
            set { this.customer = value;}
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }


        public int Months
        {
            get
            {
                return (DateTime.Now.Year * 12 + DateTime.Now.Month) - (this.openDate.Year * 12 + this.openDate.Month);
            }
        }


        public void MakeDeposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You cannot deposite a negative or a zero sum!");
            }

            this.Balance += amount;
        }


        public virtual decimal CalculateInterestAmount()
        {
            return (this.Months * this.InterestRate);
        }

        public override string ToString()
        {
            return string.Format("Owner: {0}\nAccount type: {1}\nBalance: {2:C}\nInterest: {3:C} ",
                this.Client.Name, this.GetType().Name, this.Balance, this.CalculateInterestAmount());
        }
    }
}
