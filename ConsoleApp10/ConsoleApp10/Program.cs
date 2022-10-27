using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrasi_sekolah

{
    class Apk_Adm_Sekolah
    {
        public double NIM;
        public string NamaMahasiswa, JenisKelamin, Alamat, Kelas, WaliKelas;

        //method tidak mengembalikan nilai
        public void Inputnilai()
        {
            Console.Write("Masukkan Nama Mahasiswa = ");
            NamaMahasiswa = Console.ReadLine();
            Console.Write("Masukkan Nomor Induk Mahasiswa = ");
            NIM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan JenisKelamin = ");
            JenisKelamin = Console.ReadLine();
            Console.Write("Masukkan Alamat = ");
            Alamat = Console.ReadLine();
            Console.Write("Masukkan Kelas = ");
            Kelas = Console.ReadLine();
            Console.Write("Masukkan WaliKelas = ");
            WaliKelas = Console.ReadLine();

        }

        //method tidak mengembalikan nilai
        public void Outputnilai()
        {
            Console.WriteLine("");
            Console.WriteLine("Namasiswa {0} ", NamaMahasiswa);
            Console.WriteLine("Nomor Induk Mahasiswa {0} ", NIM);
            Console.WriteLine("JenisKelamin {0} ", JenisKelamin);
            Console.WriteLine("Alamat {0} ", Alamat);
            Console.WriteLine("Kelas {0} ", Kelas);
            Console.WriteLine("WaliKelas {0} ", WaliKelas);
            Console.ReadKey();

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string sambutan;
            Console.WriteLine("\t\tSelamat Datang di aplikasi administrasi");
            Console.WriteLine("\t\t  Universitas Muhammadiyah Yogyakarta");
            Console.WriteLine("\tSilakan Masukan Data Diri Anda KeTempat yang telah Disediakan ");

            Apk_Adm_Sekolah AAS = new Apk_Adm_Sekolah();

            AAS.Inputnilai();
            AAS.Outputnilai();
            sambutan = Console.ReadLine();
        }
    }
}



