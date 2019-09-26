using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] month = new int[12];
            for (int i = 0; i < month.Length; i++)
            {
                month[i] = DateTime.DaysInMonth(DateTime.Now.Year, i + 1);
                Console.WriteLine(month[i]);
            }


            Console.ReadKey();
            
        }
    }
}
