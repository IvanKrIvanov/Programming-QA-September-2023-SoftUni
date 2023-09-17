using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veggeMenu = int.Parse(Console.ReadLine());
            double delivery = 2.5;


            double chikenPrice = chikenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double veggePrice = veggeMenu * 8.15;

            double totalPriceMenu = chikenPrice + fishPrice + veggePrice;

            double desertPrice = totalPriceMenu * 0.2;

            double finalPrice = totalPriceMenu + desertPrice + delivery;
            Console.WriteLine(finalPrice);



        }
    }
}