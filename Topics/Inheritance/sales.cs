namespace Inheritance
{
    class Sales : Employee
    {
        private decimal commision {  get; set; }
        private decimal totalSales { get; set; }
        public Sales(int id, string name, decimal loggedhours, decimal wage, decimal commision, decimal totalSales) : base(id, name, loggedhours, wage)
        {
            this.commision = commision;
            this.totalSales = totalSales;
        }
        private decimal calcBonus=>commision*totalSales;
        protected override decimal calc()
        {
            return base.calc() + calcBonus;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nSales: ${totalSales}" +
                   $"\nComission: {commision}" +
                   $"\nBonus: ${calcBonus}" +
                   $"\nNet salary: ${calc():N0}";
        }
    }
}