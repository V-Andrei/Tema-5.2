using System;

namespace Tema_5._2_Ex6
{
    public class Loan : Account
    {

        public Loan(Costumer customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Client.CostumerType == CustomerType.Individuals && this.Months < 3)
            {
                return 0;
            }

            if (this.Client.CostumerType == CustomerType.Companies && this.Months < 2)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }

    }
}
