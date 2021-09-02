using System;
using System.Collections.Generic;

namespace HomeWork_1
{
    class Tshirt
    {
        public string Size;
        public string Color;
        public float Price;
        public string Image;
        public Tshirt(string valuesize, string valuecolor, float valueprice, string valueimage)
        {
            Size = valuesize;
            Color = valuecolor;
            Price = valueprice;
            Image = valueimage;
        }
    }
    class User
    {
        public string Name;
        public string Email;
        public string street;
        public string city;
        public string zipCode;
        public User()
        {
            
            Name = "jame watson";
            Email = "email jame@gmail.com";
            street = "131/75,Phutthamonthon Road";
            city = "NakhonPathom Province";
            zipCode = "10180";
        }
       
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Tshirt tshirt1 = new Tshirt("L", "red", 500f, "t_red02_000011");
            Tshirt tshirt2 = new Tshirt("M", "black", 750f, "t_black02_000011");
            Tshirt tshirt3 = new Tshirt("S", "blue", 625f, "t_blue02_000011");
            User user = new User();
            Console.WriteLine("Name : {0}", user.Name);
            Console.WriteLine("Email : {0}", user.Email);
            Console.WriteLine("Address : {0},{1} {2}", user.street, user.city, user.zipCode);

            var Oders = new List<string> { tshirt1.Size, tshirt2.Size, tshirt3.Size };
            foreach (var Oder in Oders)
            {
               Oder.ToUpper();
            }
            Console.WriteLine();
            Console.WriteLine("The list has {0} items in it",Oders.Count);

            float total_cost = tshirt1.Price + tshirt2.Price + tshirt3.Price;
            Console.WriteLine("Totak amount is {0} baht", total_cost);

        }
      
    }
}


