namespace Inheritance
{
    class Developer : Employee
    {
        private const decimal commision = 0.03m;
        private bool taskCompleted { get; set; }
        public Developer(int id, string name, decimal loggedhours, decimal wage,bool taskC) : base(id, name, loggedhours, wage)
        {
            this.taskCompleted = taskC;
        }
        private decimal calcBonus()
        { 
            if(taskCompleted)
            {
                return commision * base.calc();
            }
            return 0;
        }
        protected override decimal calc()
        {
            return base.calc() + calcBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nTask completed: {(taskCompleted ? "YES":"NO")}" +
                   $"\nBonus: ${calcBonus()}" +
                   $"\nNet salary: ${calc():N0}";
        }
    }
}