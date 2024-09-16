namespace Inheritance
{
    public class Employee
    {
        protected const int minLoggedHr = 176;
        protected const decimal overTimeRate = 1.25m;

        public Employee(int id, string name, decimal loggedhours, decimal wage)
        {
            this.id = id;
            this.name = name;
            this.loggedhours = loggedhours;
            this.wage = wage;
        }
        public virtual void test()
        {
            Console.WriteLine("emp");
        }
        protected int id { get; set;}
        protected string name { get; set;}
        protected decimal loggedhours { get; set;}
        protected decimal wage { get; set;}

        private decimal calcOvertime()
        {
            decimal addhours = ((this.loggedhours - minLoggedHr) > 0 ? (this.loggedhours - minLoggedHr) : 0);
            return addhours * overTimeRate * this.wage;
        }
        private decimal calcBase()
        {
            return this.wage * minLoggedHr;
        }
        protected virtual decimal calc() 
        { 
            return this.calcOvertime() + this.calcBase();
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inheritance.","");
            return type+
                   "\n---------------" + 
                   $"\nID: {id}" +
                   $"\nName: \"{name}\"" +
                   $"\nLogged Hours: {loggedhours} HRS" +
                   $"\nWage: ${wage}/HR" +
                   $"\nBasic salary: ${calcBase():N0}" +
                   $"\nOvertime: ${calcOvertime()}";
        }
    }
}   
