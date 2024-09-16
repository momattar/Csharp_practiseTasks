using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //int i = 1;
            //int multiple;
            //do
            //{
            //    multiple = i * 5;
            //    Console.WriteLine(multiple);
            //    i++;
            //} while (i <= 10);
            #endregion

            #region q2
            //int number=int.Parse(Console.ReadLine());
            //int factorial = 1;
            //while (number > 0)
            //{
            //    factorial *= number;
            //    number--;
            //}
            //Console.WriteLine(factorial);
            #endregion

            #region q3
            //int sum = 0;
            //for (int i = 2; i <= 100; i+=2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region q4
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"Table of {i}");
            //    for (int j = 0; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    Console.WriteLine("_______________________");
            //}
            #endregion

            #region q5
            //Console.WriteLine("Prime Numbers between 1 and 500");
            //bool isPrime;
            //Console.WriteLine("The only even prime is 2");
            //for (int i = 3; i <= 500; i+=2)
            //{
            //    isPrime = true;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region q6
            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    for (char j = 'a'; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region q7
            //int[] ints = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    ints[i] = int.Parse(Console.ReadLine());
            //}
            //int min=ints[0];
            //int max=ints[0];
            //for (int i = 0; i < 10; i++)
            //{                
            //    if (ints[i] < min)
            //    {
            //        min = ints[i];
            //    }
            //    if (ints[i] > max)
            //    {
            //        max = ints[i];
            //    }
            //}
            //Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion

            #region q8
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int[] rev = new int[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    rev[i] = arr[arr.Length - 1 - i];
            //}
            //Console.WriteLine("Original Array");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Reversed array");
            //foreach (var item in rev)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region q9
            //int[] arr= new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int length = arr.Length;
            //int[] rev = new int[length];
            //while (length > 0)
            //{
            //    rev[arr.Length - length] = arr[length - 1];
            //    length--;
            //}
            //Console.WriteLine("Original Array");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Reversed array");
            //foreach (var item in rev)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region q10
            //for(int i=0;i<=100;i++)
            //{
            //    if(i%3==0) continue; 
            //    Console.WriteLine(i);
            //}
            #endregion

            #region q11
            //int num=int.Parse(Console.ReadLine());
            //for(int i=2;i<=num/2;i++)
            //{
            //    if(num%i==0)
            //    {
            //        Console.WriteLine("Not Prime");
            //        return;
            //    }                
            //}
            //Console.WriteLine("Prime");
            #endregion

            #region q12
            //bool isPrime;
            //int count = 0;
            //for (int i = 2; i <= 100; i++)
            //{
            //    isPrime = true;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //    if (count == 20)
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region q13
            //int evenC=0, oddC=0;
            //int posC=0, negC=0;
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    if (arr[i] % 2 == 0)
            //    {
            //        evenC++;
            //    }
            //    else
            //    {
            //        oddC++;
            //    }
            //    if (arr[i] > 0)
            //    {
            //        posC++;
            //    }
            //    else if (arr[i] < 0)
            //    {
            //        negC++;
            //    }
            //}
            //Console.WriteLine($"Even: {evenC}, Odd: {oddC}, Positive: {posC}, Negative: {negC}");
            #endregion

            #region q14
            //int terms = int.Parse(Console.ReadLine());
            //long first = 0, second = 1;
            //for (int i = 1; i <= terms; i++)
            //{
            //    Console.WriteLine(first);

            //    long next = first + second;
            //    first = second;
            //    second = next;
            //}
            #endregion

            #region q15
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    int last = arr.Length - 1;
            //    if (arr[i] == arr[last - i])
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //Console.WriteLine("Not Palindrome");
            //        return;
            //    }
            //}
            //Console.WriteLine("Palindrome");
            #endregion

            #region q16_OfflineQ
            Console.Write("Enter size of array: ");
            int n=int.Parse(Console.ReadLine());
            int[] arr=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter number of queries: ");
            int q = int.Parse(Console.ReadLine());
            int[] cnt = new int[501];
            for (int j = 0; j < n; j++)
            {
                cnt[arr[j]]++;
            }
            for (int i = 0; i < q; i++)
            {
                Console.Write("Enter a number: ");
                int query = int.Parse(Console.ReadLine());
                Console.WriteLine($"{query} : {cnt[query]}");
            }
            for(int i = 0; i < cnt.Length; i++)
                for(int j = 0; j < cnt[i]; j++)
                    Console.Write(i + " ");
            #endregion

        }
    }
}

