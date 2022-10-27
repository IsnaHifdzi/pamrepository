using System;

namespace Activity_1_kelas_C_bubble_short_sample
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void read()
        {
            // menerima angka untuk menentukan banyaknnya yang disimpan pada array
            while(true)
            {
                Console.Write("Masukan Banyaknnya Elemen pada Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("-----------------");

            //pengguna masukkan elemen pada array
            for (int i  = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("elemen array yang telah tersusun");
            Console.WriteLine("-----------------");
            for (int j = 0; j < n; j++) 
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i =1; i < n; i++)// for n -1 passes
            {
                // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j]; 
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class. 
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();

            // Pemanggilan fungsi untuk mengurutkan array 
            myList. BubbleSortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun 
            myList.display();

            // Exit

            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar."); 
            Console.Read();
        }
    }
}
