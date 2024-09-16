namespace practise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            #region 1
            //int[] sum = new int[arr.Length];
            //sum[0] = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    sum[i] = sum[i - 1] + arr[i];
            //}
            //while (true)
            //{
            //    Console.WriteLine("Enter start and end points between 0 and 4:");
            //    int start = int.Parse(Console.ReadLine());
            //    int end = int.Parse(Console.ReadLine());
            //    if (start == 0)
            //        Console.WriteLine(sum[end]);
            //    Console.WriteLine(sum[end] - sum[start - 1]);
            //    Console.WriteLine("Quit or Continue");
            //    string s = Console.ReadLine();
            //    if ((s.ToLower() == "quit"))
            //    {
            //        Environment.Exit(0);
            //    }
            //    else { continue; }
            //}
            #endregion

            #region 2
            //int[] update = new int[arr.Length + 1];

            //Console.WriteLine("Enter number of queries:");
            //int q = int.Parse(Console.ReadLine());
            //for (int i = 0; i < q; i++)
            //{
            //    Console.Write("Enter start point:");
            //    int start = int.Parse(Console.ReadLine());
            //    Console.Write("Enter end point:");
            //    int end = int.Parse(Console.ReadLine());
            //    Console.Write("Enter value:");
            //    int val = int.Parse(Console.ReadLine());
            //    update[start] += val;
            //    update[end + 1] -= val;
            //}
            //for (int i = 1; i < update.Length; i++)
            //{
            //    update[i] += update[i - 1];
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] += update[i];
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            #endregion
        }
    }
}