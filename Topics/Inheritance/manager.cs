namespace Inheritance
{
    class Manager : Employee
    {
        protected const decimal allowance = 0.05m;
        public Manager(int id, string name, decimal loggedhours, decimal wage) : base(id, name, loggedhours, wage)
        {

        }
        public override void test() {
            Console.WriteLine("manager");
        }
        private decimal calcAllowance()
        {
            return base.calc() * allowance;
        }
        protected override decimal calc()
        {
            return base.calc() + calcAllowance();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nAllowance: ${calcAllowance()}" +
                   $"\nNet salary: ${calc():N0}";
        }
    }
}