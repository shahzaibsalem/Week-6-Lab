using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5.BI;
using Task_5.UI;
using Task_5.DL;

namespace Task_5
{
     class Program
    {
        static void Main(string[] args)
        {
            int input;
           

            do
            {
                Console.Clear();
                input = Menu.Menu_Bar();
                if (input==1)
                {
                    Console.Clear();
                    Function.Add_Student();
                    Console.ReadKey();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Function.Add_Degree();
                    Console.ReadKey();
                }
                else if (input == 3)
                {
                    Console.Clear();
                    Function.Print_Higher_Merit();
                    Console.ReadKey();

                }
                else if (input == 4)
                {
                    Console.Clear();
                    Function.Reg_Students();
                    Console.ReadKey();
                }
                else if (input == 5)
                {
                    Console.Clear();
                    Function.See_Student_of_specific_program();
                    Console.ReadKey();
                }
                else if (input == 6)
                {
                    break;

                }
            } while (true);
            Console.ReadKey();

        }
    }
}
