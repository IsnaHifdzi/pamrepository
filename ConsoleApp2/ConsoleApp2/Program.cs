using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making_with_different_method
{
    class Inputdata
    {
        //Deklarasi Method Variabel
        public static double nilM, nilB;

        //Method Nilai
        public void InputData()
        {
            //Display 'Masukan Nilai Metematika = '
            Console.Write("Masukkan Nilai Matematika= ");

            //Accept nilM
            nilM = Convert.ToDouble(Console.ReadLine());

            //Display 'Masukan Nilai Bahasa Inggris = '
            Console.Write("Masukan Nilai Bahasa Inggris= ");

            //Accept nilB
            nilB = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Prosesdata
    {
        //Deklarasi Method Variabel
        public static double rarata;

        //Method yang akan merespon data
        public void ProsesData()
        {
            //Memanggil nilM dari class Inputdata
            double nilMs = Inputdata.nilM;

            //Memanggil nilB dari class Inputdata
            double nilBs = Inputdata.nilB;

            //Compute rarata = (nilM + nilB) / 2
            rarata = (nilMs + nilBs) / 2;
        }
    }
    class Outputdata
    {
        //Character status
        string status;
        //Method yang akan merespon data
        public void OutputData()
        {
            //Memanggil nilM dari class inputdata
            double nilMa = Inputdata.nilM;

            //Memanggil rarata dari class prosesdata
            double rarata2 = Prosesdata.rarata;

            //if (rarata > = 60 AND nilMs >=70)
            if (rarata2 >= 60 && nilMa >= 70)
            {
                //status = 'Lulus'
                status = "Lulus";
            } //End

            //Else
            else
            { //Begin
                //Status = 'Gagal'
                status = "Gagal";
            }//End

            //Display 'Status perserta adalah ' + status 
            Console.WriteLine("Status perserta adalah {0}", status);
            Console.ReadKey();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Inisiasi kelas
            Inputdata Input = new Inputdata();
            Prosesdata Proses = new Prosesdata();
            Outputdata Output = new Outputdata();

            //Memanggil Method InputData
            Input.InputData();

            //Memanggil Method ProsesData
            Proses.ProsesData();

            //Memanggil Method OutputData
            Output.OutputData();
        }
    }
}
