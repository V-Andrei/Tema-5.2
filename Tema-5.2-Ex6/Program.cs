using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5._2_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Raiffeisen Bank");

            Costumer firstOwner = new Costumer("George", CustomerType.Individuals);
            Deposit myDeposit = new Deposit(firstOwner, 6400, 23.55m, new DateTime(2019, 05, 28));
            bank.AddAccount(myDeposit);

            Costumer secondOwner = new Costumer("Orange", CustomerType.Companies);
            Mortgage OrangeLoanAccount = new Mortgage(secondOwner, 245000000, 34.88m, new DateTime(2018, 10, 20));
            bank.AddAccount(OrangeLoanAccount);

            Console.WriteLine(bank);

            for (int i = 0; i < bank.AllAccounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.AllAccounts[i]);
            }

            decimal withdrawAmount = 1200M;
            decimal depositAmount = 20000M;

            myDeposit.WithDraw(withdrawAmount);
            OrangeLoanAccount.MakeDeposit(depositAmount);

            Console.WriteLine("\nToday {0} withdraw {1:C} from his account, and now {0} has {2:C}"
                , myDeposit.Client.Name, withdrawAmount, myDeposit.Balance);

            Console.WriteLine("\nToday {0} make a deposit {1:C} into his account, and now {0} has {2:C}"
                , OrangeLoanAccount.Client.Name, depositAmount, OrangeLoanAccount.Balance);

            Console.ReadLine();
        }
    }
}
