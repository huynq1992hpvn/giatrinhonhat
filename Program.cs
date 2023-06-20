using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timsonhonhat
{
    internal class Program
    {
        public static int giatrimin(int[]array)
        {
            int min = array[0];
            int index = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i]<min)
                {
                    min = array[i];
                    index = i;
                }
                
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] bang = { 5, 6, 3, 8, 10 };
            int index = giatrimin(bang);
            Console.WriteLine("gia tri nho nhat la: " + bang[index]);
            Console.ReadKey();
        }
    }
}
