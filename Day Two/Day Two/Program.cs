using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Day_Two
{

    

    class Program
    {
        static void Main(string[] args)
        {                     
            

            /*INHERITANCE PRACTICE
            var newEmployee = new FullTimeEmployee
            {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };
            Debug.Assert(newEmployee.ShowFullName() == "Bill Gates", "That's not his name.");
            Debug.Assert(newEmployee.YearsEmployed == 5, "That's not how long he's been here.");
            Console.WriteLine("Name: " + newEmployee.ShowFullName() + ": " + newEmployee.YearsEmployed);
            Console.ReadLine();
            */

            //INHERITANCE
            /*
            var pinto = new CertifiedUsedCar //CALL THE INHERITANCE
            {
                Model = "Pinto",
                Price = 344.00m,
                Age = 78,
                LastInspected = DateTime.Parse("12/1/1901")
            };
             */
             /* 
             * YOU MUST MARK THE PARENT AS "abstract" IF YOU WANT IT TO BE A TEMPLATE AND NOT BE CALLED.
             * EVERYTHING THAT IS TRUE OF THE PARENT IS TRUE OF THE CHILD
            */
            //INTERFACE IS A CONSTRACT THAT SAYS CLASSES MUST HAVE CERTAIN PROPERTIES AND METHODS?

            //CASTING IN INHERITANCE RELATIONSHIPS
            /*
            var cars = new Car [] {
                new CertifiedUsedCar {Price = 3.22m},
                new UsedCar {Price = 3.44m},
                new NewCar {Price = 5446546.344m}
            };
            var car2 = (UsedCar)cars[1];
            

            }
             */



        //-----------------------------------------

            //var input = int.Parse(Console.ReadLine()); 
            //while (input % 2 == 0 && input > 1){
            //    input/=2;
            //    Console.WriteLine(input);
            //}
            //Console.ReadLine().ToString();
           
                //Line1 is it a power of 2 (under 25 char)
                //Line2 Write the number if true, do nothing if false
                //No loops allowed!
                
            //Tertiary?

            
////Contrarian
//            var input = Console.ReadLine(); //Split and loop through all words
//            Debug.Assert(!String.IsNullOrEmpty(input), "Give me a sentence!");
//            var phrase = input.Split(' ');
//            for (var i = 0; i < phrase.Length; i++)
//            {
//                switch (phrase[i]) //Switching out target word
//                {
//                    case "like":
//                        phrase[i] = "HATE";
//                        break;
//                    case "enjoy":
//                        phrase[i] = "LOATHE";
//                        break;
//                    case "always":
//                        phrase[i] = "NEVER";
//                        break;
//                    case "do":
//                        phrase[i] = "DON'T";
//                        break;
//                    case "wanna":
//                        phrase[i] = "would rather DIE than";
//                        break;
//                    case "am":
//                        phrase[i] = "am ABSOLUTELY NOT";
//                        break;
//                    default:
//                        break;
//                }
//            }
//            var joined = String.Join(" ", phrase);
//            Console.WriteLine(joined);
//            Console.ReadLine();              


//Randomizing Sound
            /*
		var snd = new string[]{  //MAKE AN ARRAY WITH STRINGS FOR LINKS
        		    "http://www.wavsource.com/snds_2015-04-12_5971820382841326/movies/alien-aliens/aliens_game_over2.wav",
                	"http://www.wavsource.com/snds_2015-04-12_5971820382841326/movies/monty_python_hg/hand_grenade.wav",
                	"http://www.wavsource.com/snds_2015-04-12_5971820382841326/movies/kindergarten_cop/tumor.wav",    
        	};
          	var randomized = new Random();  //MAKE A RANDOM NUMBER GENERATOR
                var play = snd[randomized.Next(snd.length)];  //MADE A VARIABLE PULLING A RANDOM ARRAY NUMBER UP TO 3 (.Next(3))
                try {  //TRY CATCH FOR WHEN INTERNET IS DOWN
                      SoundPlayer simpleSound = new SoundPlayer(play);  //TELLING SOUNDPLAYER TO FETCH THE RANDOMIZED STRING.
                      simpleSound.Play();  //TELLING SOUNDPLAYER TO PLAY.
             * 
             * ALTERNATIVELY: SoundPlayer simpleSound = new SoundPlayer(play).Play()
             * 
                }
                catch (Exception ex){  //WHEN EXCEPTION IS CAUGHT, RUN THIS SET ERROR MESSAGE.
                      Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
             */

            //Instead of randomized.Next(3) try randomized.Next(snd.length)
            //Don't show exception messages, because it's a security breach. Type your own string instead of ex.Message.
            //Fewer comments, don't do all caps


            //Power of 2
                //for (int i = 2; i < 1028; i++)
                //{
                //    var test = i;
                //    while (test % 2 == 0 && test > 1)
                //    {
                //        test = test / 2;
                //        if (test == 2)
                //        {
                //            Console.WriteLine(i);
                //        }
                //    }
                //}
                //Console.ReadLine();
            

            

            //To Do:
                //String Builders
                //Conversions
                //Replacing words in a paragraph
                //Randomizing an array
                //make Arrays
                //Creating Classes with Parameters
                //Creating Methods
                //Named methods
                //Overflow Methods
                




            /*CUSTOM CLASSES
                - Whenever you create a different type of object, put it in the same file. When creating new class, drop all members into the same visual studio.
                - AUTO IMPLEMENTED PROPERTIES
                - Add all properties and methods associated with the class.
                - Add XML comments to the class. Then Visual Studio shows the dropdown, the comment will be available on mouseover.
             
             */

            //var product1 = new Product();

            //product1.Name = "Eggs";
            //product1.Price = 2.33m; //m denotes currency on a number.

            //var tax = product1.CalculateTax(taxRate: 0.50m); //<--NAMED PARAMETER

            //Console.WriteLine(tax);
            //Console.ReadLine();
            

            //OPTIONAL PARAMETERS?
            //NAMED PARAMETERS?



            

            //LAB//
            //var girl = new Customer();
            //girl.Name = "Sally Williams";
            //girl.Age = 23;
            //Debug.Assert(girl.Age != 0, "Sally must be older than 0");
            //girl.DoB = DateTime.Parse("2/4/1982");
            ////Try a string format String.Format("{0} {1} {2}", girl.Name, girl.Age, girl.DoB);
            //Console.WriteLine(girl.Name, girl.Age);

            //var boy = new Customer();
            //boy.Name = "Mike Harrison";
            //boy.Age = 10;
            //Debug.Assert(boy.Age != 0, "Mike must be older than 0");
            //boy.DoB = DateTime.Parse("4/5/2005");
            //Console.WriteLine(boy.Age);
            //Console.ReadLine();


            //------------------------------LAB 3 PROB ONE
           // var thingy = new One();


           // Debug.Assert(thingy.Add(2, 3) == 5, "It's supposed to be 5!");
           // Console.WriteLine("The sum is " + thingy.Add(2, 3).ToString());
           // Console.ReadLine();
            //-----------------------------LAB 3 PROB TWO

    //        var craziness = new Crazy();
    //        Debug.Assert(craziness.DoSomething(6, 2) == 3, "That ain't right...");
    //        Debug.Assert(craziness.DoSomething(3, 3, 3) == 9, "No it's niiiiine :D");
    //        Debug.Assert(craziness.DoSomething(2, 2, 2, 2) == 16, "You want going on 17.");
    //        Console.WriteLine(craziness.DoSomething(6, 2).ToString());
    //        Console.WriteLine(craziness.DoSomething(3, 3, 3).ToString());
    //        Console.WriteLine(craziness.DoSomething(2, 2, 2, 2).ToString());
    //        Console.ReadLine();
    //    }
    //}
            //--------------------------------

    //CONSTRUCTORS (LAST FEATURE OF A CLASS)
            //Parameter Constructor Class: When it calls the constructor, it passes in the value
            //var customer1 = new Customer("Monica"); 

            //Shorthand for initializing class property
            //var customer2 = new Customer("Steven"){
            //    FirstName = "Steven"
            //};

            //----------------------------
           /*
            var product1 = new Product("Bouncy Ball", 900m, 1){
                Description = "The most lethal weapon known to man..."
            };
            product1.UnitsInStock = 2;
            Console.WriteLine(String.Format("{0} {1} {2}", product1.ProductName, product1.ProductPrice, product1.UnitsInStock, product1.Description));
            Console.ReadLine();
            */
            /*
            var customer1 = new Customer();
            customer1.FirstName = "Monica";
            customer1.LastName = "Parker";
            //customer1.BillingAddress = new Address(); 
            //^ THIS INSTANTIATES A CLASS. MUST INITIALIZE THE CLASS OR YOU'LL GET NULL ERROR. YOU CAN INITIALIZE HERE OR WITH A CONSTRUCTOR.
            customer1.BillingAddress.Street = "101 Main Street";
            //customer1.ShippingAddress = new Address();
            customer1.ShippingAddress.Street = "2 Elm Street";
            */

            //CONVERTING TO A STATIC METHOD:
            // just put static before the desired method. Then you can call the class name (i.e. Utility.Method();) instead of the class instance.

            //INHERITANCE 


            //Namespaces ==> GROUP RELATED CLASSES TOGETHER
            //Assemblies ==> dll, exe, somethind distributable



}

    

