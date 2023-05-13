using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.UI;
using Task_3.DL;
using Task_3.BL;
namespace Task_3

{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string password;
            do
            {
                Console.Clear();
                int receive = UserInterface.Main_Menu();
                if(receive==1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    password = Console.ReadLine();                       
                    Console.WriteLine("Enter role:");
                    string role = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Success!!!!");
                    Credentials c = new Credentials(name, password, role);
                    Credentials_Crub.Add_User(c);
                    
                  
                }
                else if(receive==2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter login name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter login password:");
                    password = Console.ReadLine();
                    Console.Clear();
                    if(Credentials_Crub.isAdmin()==true)
                    {
                        Console.Clear();
                        do
                        {

                            Console.Clear();
                            int choice = UserInterface.Manager_Menu();
                            if (choice == 1)
                            {
                                Console.Clear();
                                string product;
                                int price;
                                string category;
                                int stock;
                                Console.WriteLine("Enter product name:");
                                product = Console.ReadLine();
                                Console.WriteLine("Enter product price:");
                                price = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter product category:");
                                category = (Console.ReadLine());
                                Console.WriteLine("Enter product stock amount:");
                                stock = int.Parse(Console.ReadLine());
                                Console.WriteLine("Success!!!!");

                                Products p = new Products(product, price, category, stock);
                                Product_Crub.Add_Products(p);
                                Console.ReadKey();


                            }
                            else if (choice == 2)
                            {
                                Console.Clear();
                                Product_Crub.Show_Products();
                            }
                            else if (choice == 3)
                            {
                                Console.Clear();

                                Console.WriteLine("Highest price product is:");
                                int rec= Product_Crub.Highest_Product();
                                Console.WriteLine(rec);
                                Console.ReadKey();

                            }
                            else if (choice == 4)
                            {
                                Console.Clear();
                                float rec = Product_Crub.show_All_taxes();
                                Console.WriteLine("Total tax of all the buyed products is:");
                                Console.WriteLine(rec);
                                Console.ReadKey();


                            }
                            else if (choice == 5)
                            {
                                Console.Clear();
                                foreach(Products m in Product_Crub.p)
                                {
                                    if(m.stock_amount==0)
                                    {
                                        Console.WriteLine(m.product_name + " is out of stock!!!! ");
                                    }
                                }
                                Console.ReadKey();

                            }
                            else
                            {
                                break;
                            }
                        } while (true);
                        Console.ReadKey();
                    }
                    else if(Credentials_Crub.isAdmin()==false)
                    {
                        Console.Clear();

                        do
                        {
                            Console.Clear();
                            int choice = UserInterface.User_Menu();
                            if (choice == 1)
                            {

                                Console.Clear();
                                Console.WriteLine("Following are the products:");
                                Console.WriteLine("______________________________________");
                                User_Products_Crud.Show_Products_to_user();

                            }

                            else if (choice == 2)
                            {


                                Console.Clear();

                                float tax = 0;
                                Console.Clear();
                                Console.WriteLine("Enter product name:");
                                name = Console.ReadLine();
                                Console.WriteLine("Enter category:");
                                string category = Console.ReadLine();
                                foreach (Products q in Product_Crub.p)
                                {
                                    if (category == "meat")
                                    {

                                        tax = (q.product_price * 0.30f);
                                    }
                                    else if (category == "vegetable")
                                    {
                                        tax = (tax + 0.20f);
                                    }
                                    else if (category == "fruits")
                                    {
                                        tax = (tax + 0.10f);
                                    }
                                }
                                User_Product u = new User_Product(name, category, tax);
                                User_Products_Crud.Add_User_Product(u);
                            }

                            else
                            {
                                break;
                            }

                        } while (true);

                        Console.ReadKey();
                        
                    }
                }
                else
                {
                    break;
                }


            } while (true);
            Console.ReadKey();
        }
    }
}
