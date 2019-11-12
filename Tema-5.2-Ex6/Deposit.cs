using System;

namespace Tema_5._2_Ex6
{
    public class Deposit : Account, IWithDrawable
    {
        public Deposit(Costumer customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }

        public void WithDraw(decimal withdrawedSum)
        {
            if (withdrawedSum <= 0)
            {
                throw new ArgumentException("You cannot withdraw a negative or a zero sum!");
            }

            this.Balance -= withdrawedSum;
        }
    }
}
