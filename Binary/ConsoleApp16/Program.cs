using System;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];    //Array to be searched
            int n;  //Number of elements in the array
            int i;

            //Get the number of elements to store in the array
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and " + "maximum 20 elements. \n");
            }

            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Enter array elements in ascending order ");
            Console.WriteLine("-----------------------------------------");

            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

            char ch;
            do
            {
                //Accept the number to be searched
                Console.Write("\nEnter the element you want to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                //Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //Obtain the index of the middlemost element
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //Loop to search for the element in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }

                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() +
                        " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() +
                        " not found in the array\n");

                Console.WriteLine("\nNumber of comparisons: " + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
}
