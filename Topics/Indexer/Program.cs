namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip1 = new IP("192.168.1.1");
            var ip2 = new IP(192, 168, 1, 1);
            Console.WriteLine(ip1.Address);
            Console.WriteLine(ip2.Address);
        }
    }
}
