using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newint = new List<int>() { 1, 2, 3, 89, 0, 43, 2 };
            newint.Sort();
            foreach(int i in newint)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
    }
}
