using System;

namespace assgs3A2
{
    class Program
    {
        static void Main(string[] args)
        {
            //pencarian array dan nomer array
            string[] arr = new string[20];
            int n;
            int i;

            //penyimpanan elemen dari pencarian array
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }

            //masukan elemen array
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter array elements in ascending order");
            Console.WriteLine("--------------------");

            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                arr[i] = Console.ReadLine();
            }

            //pengurutan data dengan quick sort
            //menginisiasi variabel j bertipe integer//
            int j;
            for (i = 1; i < n; i++)
            {
                //Menginisialisasi temp
                string temp = arr[i];
                j = i - 1;
                while ((j >= 0) && (arr[j].CompareTo(temp) > 0))
                {
                    var ceks = arr[j].CompareTo(temp);
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }

            Console.WriteLine("--------------");
            Console.WriteLine("After Sorted\n");
            Console.WriteLine("--------------");
            for (i = 0; i < n; i++)
                Console.WriteLine("<" + (i + 1) + "> " + arr[i]);
            char ch;
            do
            {
                Console.Write("\nEnter the element you want to search: ");
                string item = Console.ReadLine();
                int lowerbound = 0;
                int upperbound = n - 1;
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item.CompareTo(arr[mid]) > 0)
                    {
                        lowerbound = mid + 1;
                    }
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item + " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item + "not found in the array");
                Console.WriteLine("\nnumber of comparisons: " + ctr);
                Console.WriteLine("\nContinue search (y/n): ");
                ch = Char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
}
