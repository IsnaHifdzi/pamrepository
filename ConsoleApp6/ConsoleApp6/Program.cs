using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        public void ArraySatuDimensi_1()
        {
            //deklarasi atau mendefinisikan array satu dimensi
            int[] A = new int[4];
            //mengisi atau menyimpan data dalam array satu dimensi
            A[0] = 7;
            A[1] = 8;
            A[2] = 9;
            A[3] = 10;
            //mengisi menggunakan perulangan for
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Masukan Elemen ke {i} = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            //membaca array dengan perulangan isi array
            Console.WriteLine($"Elemen[0] = {A[0]}");
            Console.WriteLine($"Elemen[0] = {A[1]}");
            Console.WriteLine($"Elemen[0] = {A[2]}");
            Console.WriteLine($"Elemen[0] = {A[3]}");
            Console.ReadKey();

            //membaca array dengan perulangan for
            Console.WriteLine();
            for (int i = 0; i < 4; i++)

            {
                Console.WriteLine($"Masukan Elemen ke {i}= {A[i]}");
            }
            Console.ReadKey();
        }

        public void ArraySatuDimensi_2()
        {
            //mendefinisikan array dalam satu dimensi dengan ukuran array di inputkan
            int[] B;
            int ukuran;
            Console.Write("Masukan Ukuran Array = ");
            ukuran = Convert.ToInt32(Console.ReadLine());

            //membuat objek array
            B = new int[ukuran];
            //mengisi array
            for (int i = 0; i < ukuran; i++)
            {
                Console.Write($"Masukan Elemen ke-{i} = ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            //membacaa array dengan perulangan for
            Console.WriteLine();
            for (int i = 0; i < ukuran; i++)
            {
                Console.WriteLine($"Isi Elemen Ke{i}= {B[i]}");
            }
            Console.ReadKey();
        }
        public void ArrayDuaDimensi()
        {
            //mendefinisikan array 2 dimensi
            int[,] Arr = new int[3, 4];
            //mengisi array didmensi dengan for
            Console.WriteLine("Menegisi Array 2 Dimensi");
            for (int baris = 0; baris < 3; baris++)
            {
                for (int kolom = 0; kolom < 4; kolom++)
                {
                    Console.Write($"Masukan Elemen[{baris}, {kolom}]=");
                    Arr[baris, kolom] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Menampilkan Isi Array 2 Dimensi");
            for (int baris = 0; baris < 3; baris++)
            {
                Console.WriteLine($"Isi Baris Ke-{baris + 1}");
                for (int kolom = 0; kolom < 4; kolom++)
                {
                    Console.Write($"{Arr[baris, kolom]}     ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //2   4
            //2   3   5   7
            //4   6   7
            //mendefinisikan array 2 dimensi yang memiliki jumplah berbeda-beda
            int[][] Y = new int[3][];
            //mengisi langsung 
            Y[0] = new int[2] { 2, 4 };
            Y[1] = new int[4] { 1, 3, 5, 7 };
            Y[2] = new int[3] { 4, 6, 8 };
            Console.WriteLine("Mengisi Dengan Diinput dengan mnggunakan for");
            int kolom;
            for (int b = 0; b < Y.Length; b++)
            {
                Console.Write("Masukan Jumplah Kolom = ");
                kolom = Convert.ToInt32(Console.ReadLine());
                Y[b] = new int[kolom];
                for (int k = 0; k < Y[b].Length; k++)
                {
                    Console.Write($"Masukan Elemen [{b}][{k}] = ");
                    Y[b][k] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Menampilkan Isi Array");
            for (int b = 0; b < Y.Length; b++)
            {
                for (int k = 0; k < Y[b].Length; k++)
                {
                    Console.Write($"{Y[b][k]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}



