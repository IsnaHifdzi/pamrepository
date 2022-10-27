using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;   
  
namespace Exercisee2
{    
    class program    
    {    
        //membuat variable
        static public void ihw(int[] numbers, int left, int mid, int right)    
        {
            //array of integers to values
            int[] temp = new int[25];    
            int i, ih, isn, hw;    
            ih = (mid - 1);    
            hw = left;   
            isn = (right - left + 1);     
            //terjadi pengulangan apa bila terjadi left kurang dari = ih atau mid kurang dari = right
            while ((left <= ih) && (mid <= right))    
            {    
                if (numbers[left] <= numbers[mid])    
                    temp[hw++] = numbers[left++];    
                else    
                    temp[hw++] = numbers[mid++];    
            }    
            while (left <= ih)    
                temp[hw++] = numbers[left++];    
            while (mid <= right)    
                temp[hw++] = numbers[mid++];   
            for (i = 0; i < isn; i++)    
            {    
                numbers[right] = temp[right];    
                right--;    
            }    
        }   
  
        static public void SortMerge(int[] numbers, int left, int right)    
        {    
            int mid;    
            if (right > left)    
            {    
                mid = (right + left) / 2;    
                SortMerge(numbers, left, mid);    
                SortMerge(numbers, (mid + 1), right);    
                ihw(numbers, left, (mid + 1), right);    
            }    
        }     
        static void Main(string[] args)    
        {
            {
                //membuat deklarasi untuk Insertion Sort
                //Pertama array diinisialisasi dan nilainya dicetak menggunakan for loop
                int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
                int n = 10, i, ihw2, hw, ihw3;
                Console.WriteLine("Insertion Sort");
                Console.Write("Initial array is: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                //Loop for digunakan untuk proses penyortiran yang sebenarnya
                for (i = 1; i < n; i++)
                {
                    hw = arr[i];
                    ihw3 = 0;
                    //elemen saat ini dimasukkan ke dalam posisi yang benar dalam array
                    for (ihw2 = i - 1; ihw2 >= 0 && ihw3 != 1;)
                    {
                        if (hw < arr[ihw2])
                        {
                            arr[ihw2 + 1] = arr[ihw2];
                            ihw2--;
                            arr[ihw2 + 1] = hw;
                        }
                        else ihw3 = 1;
                    }
                }
                //array urutkan ditampilkan
                Console.Write("\nSorted Array is: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.Write("\n\n ");
            Console.Write("\nMargesort");
            //Program untuk mengurutkan array numerik menggunakan Merge Sorting   
            Console.Write("\n\nEnter number of elements array: ");    
            int max = Convert.ToInt32(Console.ReadLine());    
            int[] numbers = new int[max];    
            for (int i = 0; i < max; i++)    
            {    
                Console.Write("\nEnter (" + (i + 1).ToString() + ") element array: ");    
                numbers[i] = Convert.ToInt32(Console.ReadLine());    
            }
            //array yang dimasukan belum berurutan
            Console.Write("Input int array : ");    
            Console.Write("\n");    
            for (int k = 0; k < max; k++)    
            {    
                Console.Write(numbers[k] + " ");    
                Console.Write("\n");    
            }
            //array yang masuk keluar dalam bentuk berurutan
            Console.WriteLine("MergeSort By sequential value");    
            SortMerge(numbers, 0, max - 1);    
            for (int i = 0; i < max; i++)    
                Console.WriteLine(numbers[i]);    
            Console.ReadLine();    
        }    
    }  
}  