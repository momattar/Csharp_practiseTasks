namespace T3
{
    struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public void display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Employee of ID {Id}\nHis name is {Name}\nHis age is {Age}\nHis position is {Position}\nHis Salary is {Salary}");
        }
        public void raise(double percent)
        {
            Salary +=(Salary * (percent / 100));
            Console.WriteLine($"Updated salary equals {Salary}");
        }

    }
    struct Student
    {
        public int Id;
        public string Name;
        public int Age;
        public string Phone;
        public string Address;
        public int Grade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter {i + 1}th student details:");
                while (true)
                {
                    Console.Write("Student ID = ");
                    if(int.TryParse(Console.ReadLine(),out students[i].Id))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID, try again");
                    }

                }
                Console.Write("Student name is: ");
                students[i].Name = Console.ReadLine();

                while (true)
                {
                    Console.Write("Student age = ");
                    if ((int.TryParse(Console.ReadLine(), out students[i].Age)) && students[i].Age<60 && students[i].Age>15)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid age, try again");
                    }

                }

                Console.Write("Student phone number is: ");
                students[i].Phone = Console.ReadLine();

                Console.Write("Student address is: ");
                students[i].Address = Console.ReadLine();

                while (true)
                {
                    Console.Write("Student Grade = ");
                    if ((int.TryParse(Console.ReadLine(), out students[i].Grade)) && 0 < students[i].Grade && students[i].Grade < 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade, try again");
                    }

                }
                Console.WriteLine("__________________________________");
            }
            while (true)
            {
                Console.WriteLine("Choose query number: ");
                Console.WriteLine("1.Get the minimum grade of all grades");
                Console.WriteLine("2.Get the maximum grade of all grades");
                Console.WriteLine("3.Get the average of all grades");
                Console.WriteLine("4.Get the count of grades greater than a value");
                Console.WriteLine("5.Get the count of students with a specific age");
                Console.WriteLine("Enter 'quit' to exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("GoodBye");
                    return;
                }
                int minG = students[0].Grade;
                int maxG = students[0].Grade;
                int avg = 0;
                int Grvalue = 0, countGrVal = 0, countSpAge = 0, AgeVal = 0;
                foreach (Student s in students)
                {
                    if (s.Grade < minG) minG = s.Grade;
                    if (s.Grade > maxG) maxG = s.Grade;
                    avg += s.Grade;
                    if (s.Grade > Grvalue) countGrVal++;
                    if (s.Age == AgeVal) countSpAge++;
                }
                switch (input)
                {
                    case "1":
                        Console.WriteLine($"Minimum grade is {minG}");
                        break;
                    case "2":
                        Console.WriteLine($"Maximum grade is {maxG}");
                        break;
                    case "3":
                        Console.WriteLine($"Average of grades = {avg}");
                        break;
                    case "4":
                        Console.Write("Enter the value: ");
                        Grvalue = int.Parse(Console.ReadLine());
                        Console.WriteLine(countGrVal);
                        break;
                    case "5":
                        Console.Write("Enter the value: ");
                        AgeVal = int.Parse(Console.ReadLine());
                        Console.WriteLine(countSpAge);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            #region q1
            //int num1 = 5;
            //int num2 = 7;
            //int sum = Add(num1, num2);
            //Console.WriteLine("The sum is: " + sum);
            #endregion

            #region q2
            //Console.WriteLine("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(factorial(num));
            #endregion

            #region q3
            //int n;
            //Console.WriteLine("Enter the size of the array: ");
            //n = int.Parse(Console.ReadLine());
            //if (n <= 0)
            //{
            //    Console.WriteLine("Invalid size");
            //    return;
            //}
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The maximum number in the array is: " + maxarray(arr));
            #endregion

            #region q4
            //Console.WriteLine("Enter first string:");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Enter second string:");
            //string s2 = Console.ReadLine();
            //Console.WriteLine(permutation(s1, s2));
            #endregion

            #region q5
            //Console.WriteLine("Enter the value of n:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The {n}-th Fibonacci number is: {fib(n)}");
            #endregion

            #region q6
            //print();
            #endregion

            #region q7
            //Console.WriteLine("Enter arr size:");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter {i + 1}th number");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Sum of array elements equals {arrSum(arr, n)}");
            #endregion

            #region q8
            //Employee emp = new Employee()
            //{
            //    Id = 100,
            //    Name = "MoMattar",
            //    Age = 21,
            //    Position = "CEO",
            //    Salary = 25000
            //};
            //emp.display();
            #endregion

            #region q9
            //emp.raise(50);
            #endregion

            #region q10
            //Employee[] emps = new Employee[5];
            //for(int i = 0; i < emps.Length; i++)
            //{
            //    Console.WriteLine($"Enter {i+1}th employee details:");
            //    Console.Write("Emp ID = ");
            //    emps[i].Id=int.Parse( Console.ReadLine() );

            //    Console.Write("Emp Name = ");
            //    emps[i].Name = Console.ReadLine();

            //    Console.Write("Emp Age = ");
            //    emps[i].Age = int.Parse(Console.ReadLine());

            //    Console.Write("Emp Position = ");
            //    emps[i].Position = Console.ReadLine();

            //    Console.Write("Emp Salary = ");
            //    emps[i].Salary = int.Parse(Console.ReadLine());
            //    Console.WriteLine("_______________________________");
            //}
            //double totalSal = 0;
            //double minSalary = emps[0].Salary;
            //double maxSalary = emps[0].Salary;
            //int greaterThan15K = 0;
            //foreach(Employee emp in emps)
            //{
            //    totalSal += emp.Salary;
            //    if( emp.Salary < minSalary ) minSalary = emp.Salary;
            //    if( emp.Salary > maxSalary ) maxSalary = emp.Salary;
            //    if( emp.Salary > 15000 ) greaterThan15K++;
            //}
            //Console.WriteLine($"{"Total Salaries: ".PadLeft(20)}{totalSal}");
            //Console.WriteLine($"{"Minimum Salary: ".PadLeft(20)}{minSalary}");
            //Console.WriteLine($"{"Maximum Salary: ".PadLeft(20)}{maxSalary}");
            //Console.WriteLine($"{"Count of Salaries Greater Than 15000: ".PadLeft(20)}{greaterThan15K}");
            #endregion
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static string factorial(int n)
        {
            if (n < 0)
            {
                return "Factorial is not defined for negative numbers";
            }
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return $"The factorial of {n} is {f}";
        }
        static int maxarray(int[] arr)
        {
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static bool permutation(string s1,string s2)
        {
            // todo: use freq
            // ctrl + \ + t       get to do's
            if(s1.Length != s2.Length)
                return false;
            if(string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2))
                return true;
            char[] charArray1 = s1.ToCharArray();
            char[] charArray2 = s2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            for(int i = 0;i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                    return false;
            }
            return true;
        }
        static long fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n-2);

        }
        static void print(int n=1)
        {
            if (n > 10)
            {
                return;
            }
            Console.WriteLine(n);
            print(++n);
            
        }
        static int arrSum(int[] arr, int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return arr[n - 1] + arrSum(arr, n - 1);
        }
    }
}
