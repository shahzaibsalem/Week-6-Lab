using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.UI
{
   public class UserInterface
    {
        public static int User_Menu()
        {
            int choice;
            Console.WriteLine("1.Show producte:");
            Console.WriteLine("2.Buy products:");
            Console.WriteLine("3.Exit:");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int Manager_Menu()
        {
            int choice;
            Console.WriteLine("1.Add products:");
            Console.WriteLine("2.View All products:");
            Console.WriteLine("3.Product of highest price:");
            Console.WriteLine("4.View sales tax:");
            Console.WriteLine("5.Products to be buyed");
            Console.WriteLine("6.Exit:");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int Main_Menu()
        {
            Console.WriteLine("1.Sign Up:");
            Console.WriteLine("2.Sign In:");
            Console.WriteLine("3.Exit:");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
    }
}
