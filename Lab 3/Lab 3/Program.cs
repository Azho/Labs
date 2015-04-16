using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var thisInput = Console.ReadLine();

            var result = DateTime.Parse(thisInput); //Turn the input into a date
            Console.WriteLine(result.ToString("D")); //Turn the date into a string in long form
            Console.ReadLine(); //Keep it there and pause
            */

            /*
            var message = String.Format("It cost {0:c} dollars and {1} cents", 23m, 34); //{} here is a placeholder, :c puts the $ sign in because it marks the input as currency.
            //var message2 = "It cost " + 23m + " and" + 34 + "cents";
            Console.WriteLine(message);
            Console.ReadLine();
             */

            /*
            Absolute Verbatim Operator
                   //Normally we build a string like this:
            var message = @"Hi Bob,
            How are ya doin?? Long time no see!"; //Putting the @ for Absolute Verbatim Operator lets you write whatever and it will take it. Hence the absolute verbatim.
            //Again using the AVO
            var filePath = "c:\\documents\\Notes.txt"; //For writing filepaths, for example, you need two backslash because one backslash denotes a special character.
            var filePathTwo = @"c:\documents\Notes.txt";
            Console.WriteLine(message);
            Console.WriteLine(filePath);
            Console.WriteLine(filePathTwo);
            Console.ReadLine();
             */
            /*
            var message = "Hi Bob,";
            message += "How are you?";
            message += "Hope everything is well";
            //Concatenating builds up the memory fresh every time, so with large amounts of strings use the string builder instead.

            var sb = new StringBuilder();
            sb.Append("Hi, Steven");
            sb.Append("How are you?");
            sb.Append("I'm getting whooped.");
            Console.WriteLine(sb.ToString());
            Console.ReadLine(); 
            //For best practice, use StringBuilder when concatenating strings in general.

            //Complex pattern matching? String matching?
            */

            //Regular Expressions | Used a lot for things like "screen scraping?" 
            /*var isMatch = Regex.IsMatch("applesauce", @"\d+");// \d means digit, + means at least one digit, .Match returns true or false
            Console.WriteLine(isMatch);
            Console.ReadLine();
             */

            //What is Parse?

            //Array is a data type used to represent a list of items. ARRAYS ALWAYS HAVE A FIXED SIZE. You need to set how many elements it has. Expanding the size actually creates a NEW array and adds the extra items from the old.
            //2 ways to create an array:
            //Array must be one type. You can't mix types. To do that, you need to use an object instead of an array.
            /*
             var colors = new string[] { //You don't need to put a number in the brackets because C# just counts when initializing. This is a newer version and may not be supported by older versions of C#.
                 "purple",
                 "green",
                 "red"
             };

             var states = new string[4]; //It's 0 based, so you can't assign an array to position 4, because [4] is actually the 5th item.
                 states[0] = "California";
                 states[1] = "Washington";
                 states[2] = "Texas";
             */
            /*  Array Class Examples  
            .Length
            .Sort
            .Clear
            .Search
            .Exists
            .FindAll
                */
            /*
            var news = new string[]{
                "Bigfoot Comes Forth At Last!",
                "Chocolate Discovered as Healthiest Food!",
                "Half Life 3 Confirmed!"
            };

            var randomized = new Random(); //Create the random number generator
            Console.WriteLine(news[randomized.Next(3)]); //Teling the console to write array item x to the Console
            Console.ReadLine();
            */

            /*
            var input = Console.ReadLine();
            var words = input.Split(' '); //Single quotes are for characters, double quotes are for strings.
            var reversed = words.Reverse();
            var joined = String.Join(" ", reversed); //Joining character, then the argument. (We want it joined into a string, so we need " ".)
             */
            /*

            var split = Console.ReadLine().Split(' ').Reverse();
            var joined = String.Join(" ", split);

            Console.WriteLine(joined.ToString());
            Console.ReadLine();
            */

            /*
            //Control Flow
            var animal = "dog";
            if (animal == "dog")
            {
                Console.WriteLine("Bark!");
            }
            else
            {
                Console.WriteLine("What does the fox say?");
            }

            //C# Tertiary Operator
            var message = animal == "dog" ? "Bark!" : "Chirp"; // Depending on whether animal equals dog or not, message equals either bark or chirp.
            Console.WriteLine(message);
            */

            //SWITCH STATEMENT
            /*
            var animal = "human";

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("Bark");
                    break;
                case "cat":
                    Console.WriteLine("Yang");
                    break;
                case "bird":
                    Console.WriteLine("Chirp");
                    break;
                default:
                    Console.WriteLine("Eeeeks");
                    break;
            
            } Console.ReadLine(); */
            //Switch statement will run down each to test if they are true; if nothing is true, it will use the default case. Break ensures that it will stop when it finds what it wants.
            /*
            //COALESCE OPERATOR
            string a = null;
            var b = "cat";

            var animal = a ?? b; //If a is null,  b because automatically true.
             */



            //SOME OPERATORS
            // || = or, && = and, == = equal, != = not/(beng?)


            ////////////LOOPS////////////
            /*
                        var colors = new string[]{
                            "green",
                            "red",
                            "purple"
                        };

                   //FOR LOOP
                        for (var i = 0; i < colors.Length; i++)
                        {
                            Console.WriteLine(colors[i]);

                        }
                   //FOREACH LOOP
                        foreach (var color in colors)
                        {
                        Console.WriteLine(colors);
                        }
                        //Why do we put semicolon after the array  but not after the loop?
                        //Collections are better arrays. Collections can grow to hold new content and arrays must be fixed.
                    //WHILE LOOP
                        var k = 0;
                        while (k < 100)
                        {
                            Console.WriteLine(k);
                            k++;
                        }
                    //DO WHILE LOOP
            
                        Console.ReadLine();
            */

            /*
            for (var i = 7; i < 100; i += 7)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            } Console.ReadLine();

            //GIT IS A CONTROL SOURCE SYSTEM
             */

            /*
             * 
             * 
/////////////////////////////////////////////////////HOMEWORK
                  var snd = new string[]{
                     "http://www.wavsource.com/snds_2015-04-12_5971820382841326/movies/alien-aliens/aliens_game_over2.wav",
                     "http://www.wavsource.com/snds_2015-04-12_5971820382841326/movies/monty_python_hg/hand_grenade.wav",
                     "http://www.wavsource.com/snds_2015-04-12_5971820382841326/movies/kindergarten_cop/tumor.wav",    
                  };


                  var randomized = new Random();
                  var play = snd[randomized.Next(3)];
                
                  try 
                  {
                      SoundPlayer simpleSound = new SoundPlayer(@play.ToString());
                      simpleSound.Play();
                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  Console.ReadLine();



              
           
              */
            //---------------------------------------


            //string searchWithinThis = Console.ReadLine();
            //string searchForThis = "like";
            // int firstWord = searchWithinThis.IndexOf(searchForThis);
            //                Console.WriteLine("First occurrence: {0}", "like");

            /*
            var phrase = Console.ReadLine().Split(' ');
           
            for (var i = 0; i < phrase.Length; i++)
            {
                switch (phrase[i])
                {
                    case "like":
                        phrase[i] = "HATE";
                        break;
                    case "enjoy":
                        Console.WriteLine("LOATHE");
                        phrase[i] = "LOATHE";
                        break;
                    case "always":
                        phrase[i] = "NEVER";
                        break;
                    case "do":
                        phrase[i] = "DON'T";
                        break;
                    case "want to":
                        phrase[i] = "would rather DIE than";
                        break;
                    case "am":
                        phrase[i] = "am ABSOLUTELY NOT";
                        break;
                    default:
                       break;
                }
            }
            var joined = String.Join(" ", phrase);       
               Console.WriteLine(joined);
               Console.ReadLine();
            
             */
            /*
            bool IsDivisibleByThree;
            bool IsDivisibleByFive;

            for (int i = 0; i < 100; i++)
            {
                IsDivisibleByThree = (i % 3 == 0);
                IsDivisibleByFive = (i % 5 == 0);

                if (IsDivisibleByThree && !IsDivisibleByFive)
                {
                    Console.WriteLine("Fizz");
                }
                if (IsDivisibleByFive && !IsDivisibleByThree)
                {
                    Console.WriteLine("Buzz");
                }
                if (IsDivisibleByThree && IsDivisibleByFive && i != 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
            */

            /*
            bool isPrime = true;

            for (int i = 2; i < 100; i++)
            {
                isPrime = true; //Necessary because isPrime was never set back to true after being false.
                for (int j = 2; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            */

            //Check if a number is a power of 2

           // var num = Console.ReadLine();


            var input = Console.ReadLine();
            

            for (int i = 2; i < 1028; i++)
            {
                var test = i;
                while (test % 2 == 0 && test > 1)
                {
                    test = test / 2;
                    if (test == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
            
//Make an algorithm to check if a number is a power of two.
//You can use a loop to feed numbers; however, the algorithm to check if a number is a power of two cannot use a loop.
//Also, There should be two lines of code:
//One line to check if the number is a power of 2 (and this line cannot be 25 characters long); if true, then have the next line write the number. If false, do nothing.
//Finally, you must be able to thoroughly explain why your solution works. This part is crucial.

            //HOMEWORK: Try to make this one line of code with NO loops. And tell him the reason why.
            //Tertiary?

            //Practice Ideas: Randomize an array
            //Convert Data Types: VERY IMPORTANT. DO THIS!!!
            //Loops



        }
    }
}
