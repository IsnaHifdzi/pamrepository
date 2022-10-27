using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        //Deklarasi array int dengan ukuran 63
        private int[] Isna = new int[63];

        //deklarasi variable int untuk menyimpan banyak data pada array
        private int n;

        //method untuk menerima masukan
        public void input()
        {
            //melakukan pengulangan jika elemen yang di masukan lebih dari 63
            while (true)
            {
                //input angka untuk menentukan banyaknya data yang disimpan pada array
                Console.Write("Input array untuk melanjutkan : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                //statement apabila banyaknya data kurang dari 63
                if (n <= 63)
                    break;
                //statement untuk menampilkan pesan apa bila data yang dimasukan lebih dari 63
                else
                    Console.WriteLine(" \nMax array 64 elemen ");
            }
            Console.WriteLine("");
            Console.WriteLine("Input array untuk melanjutkan  ");
            Console.WriteLine("---------------------");

            //pengguna memasukan elemen array
            for (int i = 0; i < n; i++)
            {
                Console.Write("indks ke " + (i + 1) + " : ");
                string b = Console.ReadLine();
                Isna[i] = Int32.Parse(b);
            }

        }
        //method untuk membuat selection_sort
        public void Selection_sort()
        {
            //Satu per satu batas gerakan dari subarray yang tidak disortir
            for (int i = 0; i < n - 1; i++)
            {
                int indks_min = i;
                //Temukan elemen minimum dalam array yang tidak disortir
                for (int IHW = i + 1; IHW < n; IHW++)
                {
                    if (Isna[IHW] < Isna[indks_min])
                    {
                        indks_min = IHW;
                    }
                }
                //Tukar elemen minimum yang ditemukan dengan yang elemen pertama 
                int temp = Isna[indks_min];
                Isna[indks_min] = Isna[i];
                Isna[i] = temp;
            }
        }

        //membuat method keluaran array
        public void output()
        {
            Console.WriteLine("");
            Console.WriteLine("_____________________");
            Console.WriteLine("ARRAY TELAH TERSUSUN ");
            Console.WriteLine("_____________________");
            Console.WriteLine("");
            //menyimpan array yang tersusun
            for (int IHW = 0; IHW < n; IHW++)
            {
                Console.WriteLine(Isna[IHW]);
            }
            Console.WriteLine("");
            //exit
            Console.WriteLine("Tekan enter untuk menutup");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //membuat objek baru untuk kelas program
            Program C2 = new Program();
            //pemanggilan fungsi untuk input array
            C2.input();
            //pemanggilan fungsi untuk mengurutkan array
            C2.Selection_sort();
            //pemanggilan fungsi untuk menampilkan array yang telah tersusun
            C2.output();
        }
    }
}

//essay
//1.pengurutan algoritma dengan cara melakukan penukaran data secara terus menerus sampai bisa dipastikan dalam suatu iterasi tertentu tidak ada lagi perubahan/penukaran
//2.Jika terdapat N data dan data terkoleksi dari urutan 0 sampai dengan N-1 maka algoritma pengurutan dengan metode selection sort adalah sebagai berikut :
//  --Cari data terkecil dalam interval j = 0 sampai dengan j = N-1
//  --Jika pada posisi pos ditemukan data yang terkecil, tukarkan data diposisi pos dengan data di posisi i jika k.
//  --Ulangi langkah 1 dan 2 dengan j = j + i sampai dengan j = N-1, dan seterusnya sampai j = N - 1.
//3. struktur data adalah suatu metode atau cara dalam menyusun, mengatur serta menyimpan berbagai data yang terdapat dalam suatu penyimpanan dalam sistem komputer. Data ini sendiri bermacam-macam, bisa berbentuk angka, simbol, huruf dan lain sebagainya.
//4. 1.Tipe Graph
//     Tipe Graph ini adalah tipe yang cukup sering digunakan dalam berbagai kesempatan.
//   2.Tipe Tree
//     kumpulan node dan masing-masing node tersebut tersusun dari value dan juga berbagai referensi lainnya.
//   3.Tipe Queue
//     yakni peek atau melihat data yang paling awal dari suatu Queue, dequeue atau menghapus data yang pertama dari Queue dan enqueue atau memasukkan data dalam Queue.
//   4.Tipe Stack
//     Operasi pertama ialah Peek atau memantau data teratas Stack. Operasi kedua ialah Push atau yang bisa diartikan sebagai memasukkan suatu data baru dalam Stack, dan operasi yang terakhir ialah Pop atau menghapus data yang paling atas dalam Stack.
//   5.Tipe Linked List
//     Linked List dapat di artikan sebagai daftar yang saling terhubung satu sama lain yang merupakan potongan data barmacam-macam yang juga tersimpan secara acak
//   6.Tipe Array
//     Ini adalah tipe yang memiliki kumpulan elemen dan elemen-elemen tersebut jaraknya saling berdekatan dalam memori.
//5. Cara penulisan algoritma
//   1. Cara deskripsi, yaitu penulisan algoritma menggunakan bahasa deskripsi. Cara ini terdiri dari tiga bagian yaitu judul, deklarasi, dan deskripsi.
//   2. Bagan alir atau flowchart merupakan penulisan algoritma berdasarkan notasi grafis dalam bentuk bagan urutan.
//   3. Pseudocode yaitu metode penulisan algoritma yang penampilannya menyerupai bahasa pemrograman yang digunakan pada tingkat lanjut, namun masih dapat dipahami.