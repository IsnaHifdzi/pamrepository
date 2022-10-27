using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {//Begin

            // Numeric nilB, rarata
            double nilM, nilB, rarata;

            // Character status
            string status;

            // Display 'Masukkan Nilai Matematika = '
            Console.Write("Masukkan Nilai Matematika ");

            //Accept nilM
            nilM = Convert.ToDouble(Console.ReadLine());

            // Display Masukan NIlai Bahasa Inggris = '
            Console.Write("Masukkan Nilai Bahasa Inggris ");

            // Accept nilB
            nilB = Convert.ToDouble(Console.ReadLine());

            // Compute rarata = (nilM + nilB) / 2
            rarata = (nilM + nilB) / 2;

            // if (rarata >=60 AND nilM >= 70)
            if (rarata >= 60 && nilM >= 70)
            { // Begin

                // status = 'lulus'
                status = "lulus";
            } // End

            // Else
            else
            { // Begin

                // status = 'gagal'
                status = "gagal";
            } //End

            // Display 'Status perserta adalah ' + status
            Console.WriteLine("Status perserta adalah {0}", status);
        } // End
    }
}
