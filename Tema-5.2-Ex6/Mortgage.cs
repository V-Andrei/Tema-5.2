using System;

namespace Tema_5._2_Ex6
{
    public class Mortgage : Account
    {
        public Mortgage(Costumer customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Client.CostumerType == CustomerType.Individuals && this.Months < 6)
            {
                return 0;
            }

            if (this.Client.CostumerType == CustomerType.Companies && this.Months <= 12)
            {
                return (base.CalculateInterestAmount() / 2);
            }

            return base.CalculateInterestAmount();
        }
    }
}
