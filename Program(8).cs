using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication145
{
    class Program
    {
        static void Main(string[] args)
        {
        Random rnd = new Random();

        Console.WriteLine("teadad array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = rnd.Next(1, 100);

        Console.WriteLine("maghadir array:");
        foreach (var x in arr)
            Console.Write(x + " ");
        Console.ReadKey();
        }
    }
}
