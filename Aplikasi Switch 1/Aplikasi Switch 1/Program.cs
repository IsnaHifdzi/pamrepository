using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Switch_1
{
    public class Kubus
    {
        //deklarasi variabel global 
        public double sisi;
        //membuat method berupa prosedur untuk input variabel yang diketahui
        public void inputsisi()
        {
            Console.Write("Masukkan nilai sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk menghitung luas
        public double LuasKB(double s)
        {
            return 6 * s * s;
        }
        //membuat method berupa prosedur untuk menampilkan data luas
        public void tampilsisi()
        {
            Console.WriteLine("Luas kubus adalah = " + this.LuasKB(sisi));
        }
    }
    public class balok
    {
        public double volume, panjang, lebar, tinggi;
        public void volumebalok()
        {
            Console.Write("Masukkan panjang balok = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar balok = ");
            lebar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan tinggi balok = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        public double volumebalok(double p, double l, double t)
        {
            return p * l * t;
        }
        public void tampilbalok()
        {
            Console.WriteLine("volume balok = " + this.volumebalok(panjang, lebar, tinggi));
        }
    }
    public class tabung
    {
        public double volume, jarijari, tinggi;
        public void inputJT()
        {
            Console.Write("Masukkan jari-jari = ");
            jarijari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        public double volumetabung(double r, double t)
        {
            return 3.14 * r * r * t;
        }
        public void tampilTJ()
        {
            Console.WriteLine("volume tabung = " + this.volumetabung(jarijari, tinggi));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //membuat instance untuk klas PersegiPanjang, klas Ligkaran dan klas Segitiga
            Kubus KB = new Kubus();
            balok BK = new balok();
            tabung TB = new Aplikasi_Switch_1.tabung();
            //deklarasi variabel untuk ekspresi Switch
            int pilih;
            do
            {
                //membuat tampilan Menu
                Console.WriteLine("------------MENU--------------");
                Console.WriteLine("Pilihan salah satu (1/2/3/4) : ");
                Console.WriteLine("1. Luas Kubus ");
                Console.WriteLine("2. Volume Balok");
                Console.WriteLine("3. Volume Tabung");
                Console.WriteLine("4. ERROR");
                Console.Write("Masukan Kode = ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("==============================");
                Console.WriteLine("");
                switch (pilih)
                {
                    case 1:
                        Console.WriteLine("Menghitung Nilai Luas Kubus");
                        KB.inputsisi();
                        KB.tampilsisi();
                        Console.Write("Press Enter to Continue . . . .");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Menghitung Volume Balok");
                        BK.volumebalok();
                        BK.tampilbalok();
                        Console.Write("Press Enter to Continue . . . .");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Menghitung Volume Tabung");
                        TB.inputJT();
                        TB.tampilTJ();
                        Console.Write("Press Enter to Continue. . . .");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Press Enter to Continue. . . .");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Pilihan anda salah !");
                        Console.Write("Press Enter to Continue. . . .");
                        Console.ReadKey();
                        break;
                }
            } while (pilih <= 4);        
        }
    }

}

