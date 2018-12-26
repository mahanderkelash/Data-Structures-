using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 2, 4, 1, 6, 5, -3, -9 };
            int n = 7 , temp, s;
            for(int i = 1; i<n;i++)
            {
                temp = arr[i];

                for(int j = i-1; j>=0;j--)
                {
                    if(arr[j] > temp)
                    {
                        s = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = s;
                    }
                }
                
            }

           for(int i=0;i<n;i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();

            
        }
    }
}
