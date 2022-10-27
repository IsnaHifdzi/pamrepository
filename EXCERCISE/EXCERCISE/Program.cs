using System;

namespace EXCERCISE
{
    public class Menentukan_nilai_Mahasiswa
    {
        public double Kehadiran, Activity, Exercise, UAS, Final;
        public string namasiswa, Predikat, Huruf;
        public void inputnilai()
        {
            Console.Write("Masukkan Nama Mahasiswa : ");
            namasiswa = Console.ReadLine();
            Console.Write("Masukan Nilai Kehadiran : ");
            Kehadiran = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai Actifity : ");
            Activity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai Exercise : ");
            Exercise= Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai UAS      : ");
            UAS = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=============================");
        }
        public double proses()
        {
            Final = (Kehadiran * 20 / 100 + Activity * 20 / 100 + Exercise * 30 / 100 + UAS * 30 / 100);
            if (Final >= 80)
            {
                Huruf = "A";
            }
            else if (Final >= 75 && Final < 80)
            {
                Huruf = "AB";
            }
            else if (Final >= 70 && Final < 65)
            {
                Huruf = "B";
            }
            else if (Final >= 65 && Final < 70)
            {
                Huruf = "BC";
            }
            else if (Final >= 60 && Final < 65)
            {
                Huruf = "C";
            }
            else if (Final >= 55 && Final < 60)
            {
                Huruf = "D";
            }
            else if (Final >= 50 && Final < 55)
            {
                Huruf = "E";
            }
            else if (Final < 50)
            {
                Huruf = "TL";
            }
            return Final;

        }
        public void proses2(string status)
        {
            if (status == "A") 
            {
                Predikat = "Istimewa";
            }
            else if (status == "AB" )
            {
                Predikat = "Sangat Baik";
            }
            else if (status == "B")
            {
                Predikat = "Baik";
            }
            else if (status == "BC")
            {
                Predikat = "Lebih dari Cukup";
            }
            else if (status == "C")
            {
                Predikat = "Cukup";
            }
            else if (status == "D")
            {
                Predikat = "Kurang";
            }
            else if (status == "E")
            {
                Predikat = "Sangat Kurang";
            }
            else if (status == "TL")
            {
                Predikat = "Tidak Lulus";
            }
        }
        public void output()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Atas Nama Mahasiswa     : {0} ", namasiswa);
            Console.WriteLine("Nilai Kehadiran         : {0} ", Kehadiran);
            Console.WriteLine("Nilai Actifity          : {0}", Activity);
            Console.WriteLine("Nilai Exercise          : {0}", Exercise);
            Console.WriteLine("Nilai UAS               : {0}", UAS);
            Console.WriteLine("Nilai Final             : {0}", Final);
            Console.WriteLine("Nilai Huruf             : {0} ", Huruf);
            Console.WriteLine("Predikat Anda           : {0} ", Predikat);
            Console.WriteLine("======================================");
            Console.ReadKey();
        }
        class program
        {
            static void Main(string[] args)
            {
               Menentukan_nilai_Mahasiswa NKU = new Menentukan_nilai_Mahasiswa();
                NKU.inputnilai();
                NKU.proses();
                NKU.proses2(NKU.Huruf);
                NKU.output();
            }
        }
    }
}

