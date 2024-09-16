namespace Operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10);
            Money m2 = new Money(20);
            Money m3 = m1 + m2;
            Money m4 = m2 - m1;
            Money m5 = ++m3;
            Console.WriteLine(m1>m2);
            m1.display();
            m2.display();
            m3.display();
            m4.display();
            m5.display();
            Console.WriteLine(m1==m4);
        }
    }
}
