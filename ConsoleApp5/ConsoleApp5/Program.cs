using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace segitiga
{
    class Program
    {
        static void Main(string[] args)

        {
            do
            {//membuat input 
                Console.WriteLine("");
                Console.WriteLine("\t\t Aplikasi Belajar Looping");
                Console.WriteLine("\t\t ========================");
                int i, j, k, l;
                Console.Write("Masukkan Tinggi Segitiga = ");
                l = int.Parse(Console.ReadLine());
                //deklarasi pengulngan dean for
                for (i = l; i >= 0; i--)
                {
                    for (j = i; j >= 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= l - i; k++)
                    {
                        Console.Write("*");
                    }
                    for (k = 1; k < l - i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("");
                Console.WriteLine("\t\t Tekan Enter Untuk Mengulang..");
                Console.ReadKey();
            }
            while (ConsoleKey.Enter.ToString() == "Enter");
        }
    }
}