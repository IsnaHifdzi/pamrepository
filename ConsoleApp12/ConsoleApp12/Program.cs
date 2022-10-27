using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c1
{
    //membuat class input
    class Input
    {
        //membuat method untuk input
        //mendelkarasikan variabel
        public int d;
        public void input()
        {
            //memasukan data di variabel d
            Console.Write("\tMasukan tinggi segitiga : ");
            d = Convert.ToInt32(Console.ReadLine());
        }

    }
    //class output
    class output
    {
        //mendeklarasikan variabel a,b,c
        public int a, b, c;
        //membuat method proses
        public void proses(int A)
        {
            //outerloop
            for (a = A; a >= 0; a--)
            {
                //looping no 1
                for (b = a ; b >= 0; b--)
                {
                    Console.Write("   ");
                    //untuk memberikan spasi ke samping
                }
                // looping no 2
                for (c = 1; c <= A - a; c++)
                {
                    Console.Write("     ");
                    Console.Write(c);
                    //untuk memberikan bintang dari kanan ke kiri
                }
                //looping ke 3
                for (c = 1; c < A - c; c++)
                {
                    //untuk memberikan dari kiri ke kanan
                    Console.Write("     ");
                    Console.Write(c);
                }
                Console.Write("\n");
                //memberikan baris baru atau enter
            }
        }
    }
    //membuat class program
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek untuk setiap class
            Input masuk = new Input();
            output keluar = new output();
            //membuat pengulangan
            do
            {
                //menampilkan "aplikasi belajar looping"
                Console.WriteLine("\t       looping");
                Console.WriteLine("\t------------------------");
                //memanggil mehtod di setiap class
                masuk.input();
                keluar.proses(masuk.d);
                Console.WriteLine("\tTekan Enter Untuk Mengulang...");
                Console.ReadKey();
            }
            while (ConsoleKey.Enter.ToString() == "Enter");

        }
    }
}