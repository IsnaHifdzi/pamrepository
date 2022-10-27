using System;

namespace QuickSort
{
    class Program
    {
        //array of integers to values
        private int[] arr = new int[20];
        // number of elements in array
        private int n;
        
        void read ()
        {
            while (true)
            {
                Console.Write(" Enter The Number Of Elements In The Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray Can Have Maximum 20 Elements.\n");
            }

            Console.WriteLine("\n---------------------");
            Console.WriteLine(" Enter Array Elements  ");
            Console.WriteLine("-----------------------");
           
            //get array elements
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swep the element at the index x with the element at the index y
        void swap ( int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;
            //partition the list into two parts:
            //one cotaining  elements less than or equal to pivot
            //orther containing elements greater the pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                // search for elements greater then pivot
                while((arr[i]<=pivot)&&(i<=high))
                {
                    i++;
                }
                // search  for elements less than or equal to pivot
                while ((arr[j]>pivot)&&(j>=low))
                {
                    j--;
                }
                if (i<j)//if the greater elements is on the left of the smaller elements
                {
                    //swap the elements at the index i ith the elements at the index j 
                    swap(i, j);
                }
            }
            //j now contains the index of the last element in hie sorted list
            if (low < j)
            {
                //move pivot the to its correct position in the list
                swap(low, j);
            }
            //sort the list on the left pf pivot using quick sort
            q_sort(low, j - 1);
            //sort the list on the right pf pivot using quick sort
            q_sort(j + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine(" sorted Array Elements  ");
            Console.WriteLine("------------------------");
            for(int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
        int getSize()
        {
            return (n);
        }
        static void Main(string[] args)
        {
            //declaring the objek of the class
            Program mylist = new Program();
            //accept array elements
            mylist.read();
            //calling the sorting funcional
            //firts call to quick sort algoritma
            mylist.q_sort(0, mylist.getSize() - 1);
            //display sorted array
            mylist.display();
            //to exit from the console
            Console.WriteLine("\n\nPress Enter To Exit. ");
            Console.Read();
        }
    }
}
