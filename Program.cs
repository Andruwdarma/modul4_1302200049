using System;
using System.Collections.Generic;

namespace modul4_1302200049
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 00, 02));
        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic a = input1;
            dynamic b = input2;
            dynamic c = input3;

            return a + b + c;

        }
    }


}