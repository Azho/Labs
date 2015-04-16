using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{

    public class Product
    {
        public decimal Price { get; set; }        
	}


    //NULLABLE TYPES
    //===============

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }


    public class Program
    {



        static void AddOne(int value)
        {
            value = value + 1;
        }

        static void ChangePrice(Product product)
        {
            product.Price = 9458245987.99m;   
        }

        //.NET Framework is a system of types.
        //Different categories of type. 5 FUNDAMENTAL TYPES.
            //Classes
            //Structure
            //Interface
            //Enumeration
            //Delegates

        
        //REFERENCE TYPE VS. VALUE TYPES
        //CLASSES are references, VALUES are structures.
            //System.Object <-- Class
            //System.ValueType <-- Class???
            //System.Int32 <-- Structure
        //PASSING BY VALUE OR BY REFERENCE TO A METHOD 

        //CLASS VS. STRUCTURE
        //==================
        //Classes (Reference Types, which refer to something else)
        //String, Random, HttpClient
        //Structures (Value Types, which point to something in memory)
        //DateTime, Int32, Boolean, 
        //Structure has less functionality than a class.


        //STRINGS ACT LIKE VALUE TYPES EVEN THOUGH THEY'RE REFERENCE TYPE. THEY'RE SPECIAL.
        //STRINGS ARE AN IMMUTABLE (YOU CANNOT CHANGE THE VALUES). IT DOES NOT LET YOU CHANGE THE VALUE OF THE OBJECT.
            //SINCE WE PASS EXAMPLE 3 BY VALUE TYPE, THAT DATA CANNOT BE CHANGED BY THE REFERENCE METHOD.

        //----------------------------------------------

        //TRY PARSE CHANGES DEFAULT PASSING VALUE FROM PASSING TO REFERENCE. LETS YOU MODIFY THE VALUE IN A METHOD AND HAVE THOSE CHANGES REFLECT OUTSIDE THE METHOD.
        static void Main(string[] args)
        {
            //==ARRAY LISTS==
            //MEMORY ALLOCATION HAS DEFAULT SIZE. DEFAULT SIZE IS 10.
            var countries = new ArrayList();
            countries.Add("USA");
            countries.Add("France");
            countries.Add("Russia");
            //foreach works on any IEnumerable
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            //==HASHTABLE: a key value store
            var hashCountries = new Hashtable();
            hashCountries.Add("us", "USA");
            hashCountries.Add("fr", "France");
            //YOU CAN THROW ANYTHING INTO A HASH TABLE. 
            //i.e.
            hashCountries.Add(0, new Random());
            Console.WriteLine(hashCountries["fr"]);

            string thingy = (string)hashCountries["fr"]; //YOU NEED (string) BECAUSE PROGRAM ISN'T SURE WHAT'S COMING OUT FROM "fr".

            //ArrayList and Hashtables are UNTYPED COLLECTIONS, and they work the exact same way.
            //NOT RECOMMENDED THAT YOU USE THESE.

            //==GENERIC COLLECTIONS== (STRONGLY TYPED COLLECTIONS)
            //Recommended because they're not as dangerous. They need and return specific data types.
                //List === ArrayList
                //Dictionary ===Hashtable

            var states = new List<string>(); //<> DENOTES 'GENERIC'. READ "List<string> as "List of type string".
            states.Add("Maryland"); //INTELLISENSE NOW EXPECTS THE TYPE YOU SET.
            states.Add("California");
            states.Add("Washington");

            string favoriteState = states[1]; //ARRAY LIST GAVE YOU ERROR BECAUSE IT WANTED YOU TO CAST THE OBJECT RESULT AS THE APPROPRIATE TYPE. List DOESN'T DO THAT.

            //TO COMBINE DIFFERENT DATA TYPES IN A LIST, YOU NEED A LIST OF OBJECTS AND NOT DATA TYPES. SO USE ARRAYS.

            //THIS IS A GENERIC <> STRONGLY TYPED HASHTABLE. ELIMINATES NEED TO CAST.
            var horses = new Dictionary<string, string>();
            horses.Add("u", "Unicorns don't exist, stupid.");
            horses.Add("n", "Pegasi do NOT exist");
            Console.WriteLine(horses["u"]);



            var fred = new Employee
            {
                FirstName = "Fred",
                LastName = "Rogers",
                StartDate = DateTime.Parse("1/1/1992"),
                EndDate = null //ALTERNATIVE: DateTime.MinValue (magic value, not good)
            };
            //BUT DATA TYPE CANNOT BE NULL BECAUSE VALUE TYPE IS THE DATA INFO AND NULL IS NOTHING.
            //HOW TO FIX?
                // Put a question mark directly after the data type. That makes this a nullable type.
                // REFERENCE TYPES CAN BE ASSIGNED NULL ALREADY WITHOUT ? because they are already a reference to something else and have nothing.
            if (fred.EndDate.HasValue)
            {
                Console.WriteLine(fred.EndDate);
                //SO  EndDate = DateTime.Parse("1/2/1999") WOULD PRINT THE END DATE IF HE WAS FIRED.
            }
         


            var stringPrice = "77.88";
            var price = decimal.Parse(stringPrice);
            var parsePrice = 0m;
            var couldParse = decimal.TryParse(stringPrice, out parsePrice);
            Console.Write("{0} - {1}", couldParse, price);
        }
      


        static void AddOne(string[] args)

        {
            //CHANGEPRICE METHOD IN CLASS PROGRAM
            var product1 = new Product()
            {
                Price = 6m
            };
            ChangePrice(product1); 
            //CHANGES Price TO THE REFERENCE VALUE IN METHOD BECAUSE IT'S PASSING BY REFERENCE.

            //YOU'RE PASSING THE PRODUCT BY VALUE AND NOT BY REFERENCE, SO YOU'LL GET THE METHOD'S VALUE FOR IT.

            //PASSING BY VALUE: Passing a copy of something instead of the original thing.
            //EVERYTHING IN C# IS PASSED BY VALUE BY DEFAULT. PASSING A VALUE TYPE BY VALUE CREATES A COPY OF CONTENT. PASSING A REFERENCE TYPE BY VALUE CREATES COPY OF A REFERENCE, OR LOCATION.
            //Value of value type is data, and value of reference type is reference.




            /*
            //VALUE TYPE
            var a = 3;
            var b = a; //Copies the data of A and puts that into a new variable. 
            a = 5;
            Console.WriteLine(b); //Should be 3.

            //REFERENCE TYPE
            var product1 = new Product { Price = 3.22m };
            var product2 = product1;
            product1.Price = 9999.00m;
            Console.WriteLine(product2); //Should equal product1.
             */

            //ARRAYS ARE NOT ALWAYS IDEAL. COLLECTION CLASSES ARE SOMETIMES BETTER.

            //COLLECTIONS
                //COMMONLY USED: ArrayList, HashTable





        }



         
    }

    

}
