using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_1
{
    class Program
    {
        //deklarasi variable dengan tipe data double
        double segitiga;

        //membuat method cekbilagan()
        public void cekbilangan()
        {
            //menampilkan string "Masukan Jumplah Bilangan yang akan dicari genap dan ganjilnya"
            Console.Write("Masukan Jumplah Bilangan yang akan dicari Genap dan Ganjilnya : ");

            //membaca input user dan mengubah tipe datanya menjadi double
            segitiga = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("Hasil Pencarian Bilangan Ganjil dan Genap");
            Console.WriteLine("==========================================");
            Console.WriteLine("");

            //membuat perulangan "for" dimulai dengan value dari i=0, sampai dengan i <= input dari user
            for (int i = 1; i <= segitiga; i++)
            {
                //membuat decision making untuk menentukan modulus
                if (i % 2 == 0)
                {
                    Console.Write("\nBilangan {0} adalah merupakan bilangan genap", i);
                }
                else
                {
                    Console.Write("\nBilangan {0} adalah merupakan bilangan ganjil", i);
                }
            }
        }
        static void Main(string[] args)
        {
            //deklarasi variable "jawaban" dengan tipe data string
            string Jawaban;

            //deklarasi variable "ualang" dengan tipe data int
            int Ulang;

            //membuat objek baru dari class program
            Program p = new Program();

            //membuat method cekbilangan () dari class program 
            p.cekbilangan();

            Console.WriteLine("\n");
            Console.WriteLine("Apakah ingin mencoba mencari bilangan ganjil dan genap lagi ?");

            //memberikan value untuk variable "jawaban" dari input user 
            Jawaban = Console.ReadLine();

            //membuat kondisi apakah input user berupa karekter 'y' atau 'Y'
            if (Jawaban.Equals("y") || Jawaban.Equals("Y"))
             {
                Console.WriteLine("Berapa kali anda ingin mengulang pencarian bilangan genap ?");

                //membaca input user dan mengubah tipe datanya menjadi int
                Ulang = Convert.ToInt32(Console.ReadLine());

                //membuat perulang untuk mrngulang mencari bilangan genap sebanyak yang diinput user
                while (Ulang > 0)
                {
                    //memanggil method cekbilangan() dari class program 
                    p.cekbilangan();
                    Console.WriteLine("\n");
                    //decrement
                    Ulang--;
                }
                Console.ReadKey();
            }
        }
    }
}

    