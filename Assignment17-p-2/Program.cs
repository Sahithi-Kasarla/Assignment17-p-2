using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_p_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct herbalProduct = new HerbalProduct();
            herbalProduct.SetInformation(1, "Herbal Shampoo", 650.50, "Aloe Vera",
            DateTime.Parse("2023-10-13"), DateTime.Parse("2025-01-04"));
            Console.WriteLine("Herbal Product Details:");
            herbalProduct.ShowDetails();
            Console.ReadKey();
        }
    }
}

