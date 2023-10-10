using System;
using System.Collections;

namespace Beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);

            int oneCounter = 0;

            foreach (var c in binary)
            {
                if (c == '1')
                {
                    oneCounter++;
                }
            }

            Console.WriteLine(oneCounter);
        }
    }
}