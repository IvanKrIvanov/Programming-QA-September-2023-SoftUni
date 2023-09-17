using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());

            double sneakers = fee * 0.6;
            double team = sneakers * 0.8;
            double basketball = team / 4;
            double accessories = basketball / 5;
            double total = fee + sneakers + team + basketball + accessories;
            Console.WriteLine(total);

        }
    }
}