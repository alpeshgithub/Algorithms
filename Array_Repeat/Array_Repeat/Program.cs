using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] no_arr = new int[100];
            int[] no_arr1 = new int[100];
            Console.Write("Enter the Array Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=n-1;i++)
            {
                Console.Write("Enter the Value of Array[" + i + "]: ");
                no_arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int ii = 0; ii < n; ii++)
            {
                if (no_arr1[no_arr[ii]] == 0)
                {
                    no_arr1[no_arr[ii]] = no_arr[ii];
                }
                else
                {
                    Console.WriteLine("duclicate found");
                }
            }
            Console.ReadKey();
        }
    }
}
