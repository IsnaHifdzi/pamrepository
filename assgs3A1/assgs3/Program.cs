using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg3A1
{
    class Program
    {
        //membuat Dafatar nama mahasiswa 
        static List<string> DaftarMahasiswa = new List<string>();
        static string search_nama;
        static string[] DaftarNama = new string[] {"Aldi Ahmad Fauzi", "Agung Prasetya", "Isna Hifdzi Walidain", "M. Briyan", "M. iqbal ", "Jundi Jundullah", };
        static void Main(string[] args)
        {
            //membuat peulangan progran dengan do while
            var arr = InputDaftarNama();
            string lanjut;
            do
            {
                search_nama = InputNama();
                Array.Sort(arr, StringComparer.InvariantCultureIgnoreCase);
                LinearSearch(arr, search_nama);
                BinarySearch(arr, search_nama);
                Console.Write("Lanjut? [y/n] : ");
                lanjut = Console.ReadLine().ToLower();
            } while (lanjut == "y");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Program Selesai");
            Console.ReadKey();
        }
        private static string[] InputDaftarNama()
        {
            string temp_nama;
            int maks;
            while (true)
            {
                try
                {
                    //membuat banyaknya penccarian yang akan dicari dengan max 20
                    Console.Write("Masukan Banyaknya Pencarian [max 20] : ");
                    maks = Convert.ToInt32(Console.ReadLine());
                    if (maks <= 20) break;
                }
                catch
                {
                    Console.WriteLine("Masukkan angka kurang dari atau sama dengan 20");
                }
            }

            DaftarMahasiswa.Clear();
            while (DaftarMahasiswa.Count < maks)
            {
                //nama sesuai daftar nama 
                Console.Write($"[{DaftarMahasiswa.Count + 1}] Masukkan Nama : ");
                temp_nama = Console.ReadLine();
                if (temp_nama == "sudah")
                    break;
                DaftarMahasiswa.Add(temp_nama);
            }
            return DaftarMahasiswa.ToArray();
        }
        private static string InputNama()
        {
            //besar huruf yang dicari harus sama
            Console.WriteLine("______________________________________________");
            Console.Write("Masukkan Nama yang akan dicari: ");
            return Console.ReadLine();
        }
        private static void LinearSearch(string[] array, string query)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (string.Compare(array[i], query) == 0)
                {
                    Console.WriteLine($"[Linear] Ditemukan setelah {i + 1,2} kali pengulangan, indeks hasil : {i}");
                    return; // Keluar dari fungsi
                }

            }
            Console.WriteLine("Tidak Ditemukan");
        }
        private static void BinarySearch(string[] array, string query)
        {
            int hasil = 0;
            // 2. pencarian binary
            // Lower Bound
            int min = 0;
            // Upper Bound
            int max = array.Length - 1;
            // Counter
            int counter = 0;

            while (min <= max)
            {
                counter++;
                // Median
                int mid = (min + max) / 2;
                int comparation = String.Compare(query, array[mid], true);
                if (comparation == 0)
                {
                    hasil = ++mid;
                    Console.WriteLine($"[Binary] Ditemukan setelah {counter,2} kali pengulangan, indeks hasil : {hasil - 1}");
                    return; //menyelesaikan program
                }
                if (comparation < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            //jika nama tidak di temukan
            Console.WriteLine("Tidak Ditemukan");
        }
    }
}