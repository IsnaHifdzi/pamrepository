using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericise2
{
    public class exericesnota
    {
        double sugar = 12000;
        double rice = 11500;
        double cooking = 14500;
        double egg = 19500;
        double choose, a, b, c, d, gula, nasi, minyak, telur;
        double Total;

        public void menu()
        {
            do
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Sugar        Rp. 12.000/kg");
                Console.WriteLine("2.Rice         Rp. 11.500/kg");
                Console.WriteLine("3.Cooking      Rp. 14.500/L");
                Console.WriteLine("4.Egg 1kg      Rp. 19.500/kg");
                Console.WriteLine("5.Finish /Exit");
                Console.Write("Choose (1/2/3/4/5) : ");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("How many kilograms of sugar do you want to buy?");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(a + " kg of sugar successfully added to the cart");
                    gula = a * sugar;
                }
                else if (choose == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("How many kilograms of rice do you want to buy?");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(b + " kg of rice successfully added to the basket");
                    nasi = b * rice;
                }
                else if (choose == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("How manny liters of cooking oil do you want to buy?");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(c + "liter of cooking oil successfulyy added to the cart");
                    minyak = c * cooking;
                }
                else if (choose == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("How many kilograms of eggs do you want to buy?");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(d + " kg of eggs successfully added to cart");
                    telur = d * egg;
                }
                else if (choose == 5)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Receipt : ");
                    Console.WriteLine(a + " kg sugar\t\t= Rp." + gula + ",00,");
                    Console.WriteLine(b + " kg rice\t\t= Rp." + nasi + ",00,");
                    Console.WriteLine(c + " L cooking oil \t= Rp." + minyak + ",00,");
                    Console.WriteLine(d + " kg egg\t\t= Rp." + telur + ",00,");
                }
            } while (choose < 5);
        }
        public void select()
        {
            Total = gula + nasi + minyak + telur;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\t\tTotal\t= " + Total + ",00,");
            Console.WriteLine("");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string kode;
            Console.WriteLine("welcome to the Berkah Grocery Application");
            Console.WriteLine("Please select the item from the purchase menu to buy");
            Console.WriteLine("====================================================");

            exericesnota not = new exericesnota();
            not.menu();
            not.select();
            Console.WriteLine("Do you still want to shop? ");
            Console.WriteLine("Press 'Yes' to continue shopping or press 'Enter to Exit'");
            kode = Console.ReadLine();
            do
            {
                not.menu();
                not.select();
                Console.WriteLine("Do you still want to shop? ");
                Console.WriteLine("Press 'Yes' to continue shopping or press 'Enter to Exit'");
            } while (kode == "Yes");

        }
    }
}