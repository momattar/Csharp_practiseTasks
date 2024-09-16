namespace Delegate
{
    delegate int del(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            del d1 = delegate (int x,int y) {  return x + y; };
            var Emps = new Employee[]
            {
                new Employee{ID = 1, Gender = 'M', TotalSales = 99999m, Name = "MoMattar"},
                new Employee{ID = 2, Gender = 'F', TotalSales = 62000m, Name = "JordanSuzy"},
                new Employee{ID = 3, Gender = 'M', TotalSales = 25000m, Name = "Deadpool"},
                new Employee{ID = 4, Gender = 'M', TotalSales = 06070m, Name = "HarryPotter"},
                new Employee{ID = 5, Gender = 'F', TotalSales = 69696m, Name = "ScarletWitch"},
                new Employee{ID = 6, Gender = 'F', TotalSales = 96969m, Name = "AnaDeArmas"},
                new Employee{ID = 7, Gender = 'M', TotalSales = 00000m, Name = "FavEx"},
                new Employee{ID = 8, Gender = 'M', TotalSales = 10000m, Name = "RickGrimes"}
            };
            var rep = new Report();
            rep.ProcessEmployees(Emps, "Sales greater than $60K", isGr60k);
            rep.ProcessEmployees(Emps, "Sales between $60K and $30k", bet30kAND60k);
            rep.ProcessEmployees(Emps, "Sales less than $30K", isLess30k);

        }
        static bool isGr60k(Employee e) => e.TotalSales > 60000;
        static bool bet30kAND60k(Employee e) => e.TotalSales > 30000 && e.TotalSales < 60000;
        static bool isLess30k(Employee e) => e.TotalSales < 30000;
    }
    
}

