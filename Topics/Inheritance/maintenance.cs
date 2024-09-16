namespace Inheritance
{
    class Maintenance : Employee
    {
        protected const int hardship = 100;
        public Maintenance(int id, string name, decimal loggedhours, decimal wage) : base(id, name, loggedhours, wage)
        {

        }
        protected override decimal calc()
        {
            return base.calc() + hardship;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nHardship: ${hardship}" +
                   $"\nNet salary: ${calc():N0}";
        }
    }
}