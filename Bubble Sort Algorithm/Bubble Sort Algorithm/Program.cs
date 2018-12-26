using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[5];

            Console.WriteLine("Enter the 5 integers to sort them out : ");
            for(int i = 0; i< 5; i++)
            {
                arr[i] = Convert.ToInt32 (Console.ReadLine());
            }
            int temp = 0;
            for(int i =0; i<4;i++)
            {
                for(int j = 0; j < 4-i; j++ )
                {
                    if(arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];

                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("your sorted array \n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i]);
            }

            Console.ReadKey();
            
        }
    }
}
