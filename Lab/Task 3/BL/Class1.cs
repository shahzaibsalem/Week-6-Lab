using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.DL;

namespace Task_3.BL
{
    public class Product_Crub
    {
        public static List<Products> p = new List<Products>();
        public static void Add_Products(Products s)
        {
            p.Add(s);
        }
        public static void Show_Products()
        {
            foreach (Products q in p)
            {
                Console.WriteLine(q.product_name);
                Console.WriteLine(q.product_price);
                Console.WriteLine(q.category);
                Console.WriteLine(q.stock_amount);
            }
            Console.ReadKey();
        }
        public static int Highest_Product()
        {
            int high=0;
            foreach (Products q in p)
            {
                if (q.product_price > high)
                {
                    high = q.product_price;
                }
            }
            return high;
        }
        public static float show_All_taxes()
        {
            float tax=0;
            foreach (User_Product p in User_Products_Crud.user)
            {
                tax = tax + p.tax;
            }
            return tax;
        }
      

    }
    public class Credentials_Crub
    {
        public static List<Credentials> c = new List<Credentials>();
        public static bool isAdmin()
        {
            bool flag = false;
            foreach (Credentials q in c)
            {
                if (q.role == "admin")
                {
                    flag = true;
                    break;
                   
                }
            }
            return flag;
        }
        public static void Add_User(Credentials s)
        {
            c.Add(s);
        }
       
    }
    public class User_Products_Crud
    {
       public static List<User_Product> user = new List<User_Product>();
        public static void Show_Products_to_user()
        {
            foreach (Products q in Product_Crub.p)
            {
                Console.WriteLine(q.product_name);
                Console.WriteLine(q.product_price);
                Console.WriteLine(q.category);
                Console.WriteLine(q.stock_amount);
            }
            Console.ReadKey();
        }
        public static void Add_User_Product(User_Product q)
        {
            foreach(User_Product m in  user)
            {
                if(m.category=="meat")
                { 
                    foreach(Products n in Product_Crub.p )
                    {
                        n.stock_amount = n.stock_amount - 1;
                    }
                }
               else if (m.category == "vegetable")
               {
                    foreach (Products n in Product_Crub.p)
                    {
                        n.stock_amount = n.stock_amount - 2;
                    }
               }
                else if (m.category == "meat")
                {
                    foreach (Products n in Product_Crub.p)
                    {
                        n.stock_amount = n.stock_amount - 4;
                    }
                }
            }
            user.Add(q);   
        }
    }

}
