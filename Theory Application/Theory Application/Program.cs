using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_Application
{


    class Program
    {
        static void Main(string[] args)
        {

            var productCatalog = new ProductCatalog();
            Console.WriteLine(productCatalog.Lookup());
            Console.ReadLine();



            //Console.WriteLine("Please input value here:" + "\n********************");
            //var x = Console.ReadLine();
            //var lab = new Lab();
            //Console.WriteLine(lab.TryParse(x));
            //Debug.Assert(lab.TryParse("89898") == 89898, "That's not the same number.");
            //Debug.Assert(lab.TryParse("I am not a number") == null, "It's supposed to be null.");
            //Debug.Assert(lab.TryParse(null) == null, "It's supposed to stay null.");
            //Debug.Assert(lab.TryParse("6.5") == null, "A string is not an int!");
            //Console.ReadLine();



        }
    }


    public static class Lab
    {
        public static int? TryParse(this string x)
        {
            //Wrap existing TryParse()
            var y = 0;
            var result = int.TryParse(x, out y);//OUT: Passes value type by reference.
            return result == true ? (int?)y : null; //return null)
            //Want it to return as string
        }
    }





    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class ProductCatalog
    {
        public List<Product> products { get; set; }

        public ProductCatalog()//Specialized method
        {
            products = new List<Product>(){
            new Product {ID = 123, Name = "Bouncy Ball", Price = 1.50m},
            new Product {ID = 456, Name = "Kite", Price = 2.50m},
            new Product {ID = 789, Name = "Parcheezi (That's probably not even how you spell it", Price = 3.50m},
        };
        }

        public string Lookup()
        {
            Console.WriteLine("Enter product ID:");
            var choice = Console.ReadLine().TryParse();
            Debug.Assert(products != null, "List is empty.");
            foreach (var product in products) // product = products[?]; => Product class
            {
                if (choice == product.ID)
                {
                    return product.Name;
                }

            }
            return "Please input a valid ID.";

        }


    }
}






