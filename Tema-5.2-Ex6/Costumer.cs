namespace Tema_5._2_Ex6
{
    public partial class Costumer
    {
        private string name;
        private CustomerType custumerType;

        public Costumer(string name, CustomerType custumerType)
        {
            this.name = name;
            this.custumerType = custumerType;
        }

        public string Name
        {
            get {  return this.name; }
            private set {  this.name = value; }
        }
        public CustomerType CostumerType
        {
            get {  return 0; }
            private set { this.custumerType = value; }
        }
    }
}
