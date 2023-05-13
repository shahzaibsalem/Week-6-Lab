using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.DL
{
   public class Credentials
    {
       public string username;
       public string password;
       public string role;
       

        public Credentials(string username , string password,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public Credentials(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.role = null;
        }
       
    }
    public class Products
    {
        public string product_name;
       public int product_price;
       public string category;
       public int stock_amount;
       
        public Products(string product, int price,string category,int stock)
        {
           product_name=product;
           product_price=price;
           this.category = category;
           stock_amount=stock;
        }


    }
    public class User_Product
    {
        public string name;
        public string category;
        public float tax;
        public User_Product(string name,string category,float tax)
        {
            this.name = name;
            this.category = category;
            this.tax = tax;
        }
    }

}
