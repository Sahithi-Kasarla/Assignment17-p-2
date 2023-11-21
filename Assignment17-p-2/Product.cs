using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment17_p_2
{
    public class Product
    {
       public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Product ID: {id}");
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Product Price: {price}");
        }

        public virtual void SetInformation(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}


