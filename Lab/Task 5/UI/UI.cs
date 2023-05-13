using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5.DL;

namespace Task_5.UI
{
    public class Menu
    {
        public static int Menu_Bar()
        {
            Console.WriteLine("1.Add Student:");
            Console.WriteLine("2.Add Degree Program:");
            Console.WriteLine("3.Generate Merit:");
            Console.WriteLine("4.View Registered Students:");
            Console.WriteLine("5.View Student of a specific program::");
            Console.WriteLine("6.Exit:");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
       

    }
   
}
