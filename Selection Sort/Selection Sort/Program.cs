using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 6, 5, 4 };
            int n = 5, temp = 0;

            for (int i = 0; i< n-1;i++)
            {
                for(int j =i+1;j<n;j++)
                {
                    if(arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for(int i = 0; i<n;i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
