using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sambutan
            Console.WriteLine();
            Console.WriteLine("           ==================================================== ");
            Console.WriteLine();
            Console.WriteLine("                   Selamat Datang di  Cafe Qita-Qita ");
            Console.WriteLine();
            Console.WriteLine("              Kami Melayani Pembayaran Costemer Berkualitas ");
            Console.WriteLine();
            Console.WriteLine("           ==================================================== ");

            transaksi:

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Menu Pilihan ");
            Console.WriteLine(" ------------------- ");
            Console.WriteLine(" 1. Es Jeruk = Rp 2.500 ");
            Console.WriteLine(" 2. Kopi Capucino = Rp 4.500 ");
            Console.WriteLine(" 3. Nasi Goreng = Rp 6.000 ");
            Console.WriteLine(" 4. Roti Bakar = Rp 5.000 ");
            Console.WriteLine(" 5. Mie Goreng = Rp 3.000");
            // Deklarasi Variabel
            string pilihan, ulang;
            int quantity;
            int EsJeruk = 2500, Kopicapucino = 4500, Nasigoreng = 6000;
            int rotibakar = 5000, miegoreng= 3000;
            int totalHarga, tunai, kembalian = 0;

            Console.WriteLine();

            Console.Write("Masukkan Angka Pilihan: ");
            pilihan = Convert.ToString(Console.ReadLine());
            // 1. input Es Jeruk
            if (pilihan == "1")
            {
                Console.WriteLine();
                Console.WriteLine("   1.Es Jeruk  ");
                Console.WriteLine("===============");

                // 2. input quantity

                Console.WriteLine();
                Console.Write(" Masukkan Quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                // 3. Proses total harga

                totalHarga = EsJeruk * quantity;

                // 4. Output total harga

                Console.WriteLine();
                Console.WriteLine(" #=================#==============# ");
                Console.WriteLine("    Total Harga: Rp {0}",totalHarga);

                // 5. Input tunai

                Console.Write("         Tunai: Rp ");
                tunai = Convert.ToInt32(Console.ReadLine());

                // 6. Proses kembalian

                kembalian = tunai - totalHarga;

                // 7. Output kembalian

                Console.WriteLine("      Kembalian: Rp {0}",kembalian);
                Console.WriteLine(" #=================#==============#");

            }

            // 1. input Kopi Capucino

            if (pilihan == "2")
            {
                Console.WriteLine();
                Console.WriteLine("    2.Kopi Capucino  ");
                Console.WriteLine("=======================");

                // 2. input quantity

                Console.WriteLine();
                Console.Write(" Masukkan Quantity: ");
                quantity = Convert.ToByte(Console.ReadLine());

                // 3. Proses total harga

                totalHarga = Kopicapucino * quantity;

                // 4. Output total harga

                Console.WriteLine();
                Console.WriteLine(" #=================#==============# ");
                Console.WriteLine("    Total Harga: Rp {0}",totalHarga);

                // 5. Input tunai

                Console.Write("         Tunai: Rp ");
                tunai = Convert.ToInt32(Console.ReadLine());

                // 6. Proses kembalian

                kembalian = tunai - totalHarga;

                // 7. Output kembalian

                Console.WriteLine("      Kembalian: Rp {0}",kembalian);
                Console.WriteLine(" #=================#==============# ");

            }
            // 1. input Nasi Goreng
            if (pilihan == "3")
            {
                Console.WriteLine();
                Console.WriteLine("    3.Nasi Goreng ");
                Console.WriteLine("====================");

                // 2. input quantity

                Console.WriteLine();
                Console.Write(" Masukkan Quantity: ");
                quantity = Convert.ToByte(Console.ReadLine());

                // 3. Proses total harga

                totalHarga = Nasigoreng * quantity;

                // 4. Output total harga

                Console.WriteLine();
                Console.WriteLine(" #=================#==============# ");
                Console.WriteLine("    Total Harga: Rp {0}",totalHarga);

                // 5. Input tunai

                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToInt32(Console.ReadLine());

                // 6. Proses kembalian

                kembalian = tunai - totalHarga;

                // 7. Output kembalian

                Console.WriteLine("     Kembalian: Rp {0}",kembalian);
                Console.WriteLine(" #=================#==============# ");

            }

            // 1. input Roti Bakar

            if (pilihan == "4")
            {
                Console.WriteLine();
                Console.WriteLine("   4.Roti Bakar  ");
                Console.WriteLine("====================");

                // 2. input quantity

                Console.WriteLine();
                Console.Write(" Masukkan Quantity: ");
                quantity = Convert.ToByte(Console.ReadLine());

                // 3. Proses total harga

                totalHarga = rotibakar * quantity;

                // 4. Output total harga

                Console.WriteLine();
                Console.WriteLine(" #=================#==============# ");
                Console.WriteLine("    Total Harga: Rp {0}",totalHarga);

                // 5. Input tunai

                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToInt32(Console.ReadLine());

                // 6. Proses kembalian

                kembalian = tunai - totalHarga;

                // 7. Output kembalian

                Console.WriteLine("      Kembalian: Rp {0}",kembalian);
                Console.WriteLine(" #=================#==============# ");

            }

            // 1. input Mie Goreng

            if (pilihan == "5")
            {
                Console.WriteLine();
                Console.WriteLine("    5.Mie Goreng ");
                Console.WriteLine("====================");

                // 2. input quantity

                Console.WriteLine();
                Console.Write(" Masukkan Quantity: ");
                quantity = Convert.ToByte(Console.ReadLine());

                // 3. Proses total harga

                totalHarga = miegoreng * quantity;

                // 4. Output total harga

                Console.WriteLine();
                Console.WriteLine(" #=================#==============# ");
                Console.WriteLine("    Total Harga: Rp {0}",totalHarga);

                // 5. Input tutnai

                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToInt32(Console.ReadLine());

                // 6. Proses kembalian

                kembalian = tunai - totalHarga;

                // 7. Output kembalian

                Console.WriteLine("      Kembalian: Rp {0}",kembalian);
                Console.WriteLine(" #=================#==============# ");

            }
            // Mengulang transaksi

            Console.WriteLine();
            Console.Write(" Apakah anda ingin mengulang transaksi?[y / t] : ");
            ulang = Convert.ToString(Console.ReadLine());
            if (ulang == "y" || ulang == "Y")
            goto transaksi;

            // Penutup

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ========================================================");
            Console.WriteLine();
            Console.WriteLine("         Terimakasi Telah Melakukan Pembayaran!!! ");
            Console.WriteLine();
            Console.WriteLine("      Kami Memberikan Harga Yang Ramah Tapi Bukan Murahan ");
            Console.WriteLine();
            Console.WriteLine("         Menurut Kami Kualitas itu nomer 1 ");
            Console.WriteLine();
            Console.WriteLine("                     Cafe Qita-Qita ");
            Console.WriteLine();
            Console.WriteLine(" ========================================================");

            Console.WriteLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}