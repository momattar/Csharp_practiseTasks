using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Report
    {
        public delegate bool Illegable(Employee employee);
        public void ProcessEmployees(Employee[] employees, string title,Illegable illegable)
        {
            int count = 0;

            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                
                if (illegable(e))
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"ID: [{e.ID}], TotalSales: ${e.TotalSales.ToString().PadLeft(5,'0')}, Employee Name: {e.Name.PadRight(20,' ')}, Gender: '{e.Gender}' \n");
                }
                
            }
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Can't find employees in this category\n");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
