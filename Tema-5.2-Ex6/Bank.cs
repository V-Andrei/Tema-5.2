using System.Collections.Generic;

namespace Tema_5._2_Ex6
{
    public class Bank
    {
        private string name;
        private IList<Account> allAccounts;

        public Bank(string name)
        {
            this.Name = name;
            this.allAccounts = new List<Account>();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        internal IList<Account> AllAccounts
        {
            get { return new List<Account>(this.allAccounts); }
        }

        //Methods
        public void AddAccount(Account newAccount)
        {
            this.allAccounts.Add(newAccount);
        }

        public override string ToString()
        {
            return string.Format("The Bank \"{0}\"\nOpened accounts: {1}", this.Name, this.AllAccounts.Count);
        }
    }
}
