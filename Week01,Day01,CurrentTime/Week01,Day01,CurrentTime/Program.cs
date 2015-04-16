using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01_Day01_CurrentTime
{
    /// <summary>
    /// Putting triple slash after namespace gives you a nice block of XML comments. (What is xml?)
    /// 
    /// This gives you intellisense when making your own custom classses. I think this will show up when other people look at your stuff, so you can use it to explain stuff.
    /// 
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            
        /*
            var whatTimeIsIt = DateTime.Now;            
            Console.WriteLine(whatTimeIsIt);
            Console.ReadLine();
          */  

            //Debug class

            //var a = 3;
            //var b = 0; //We're making the assumption here that b > 0. Debugging makes sure our assumptions are true. Ctrl + . when you see BLUE UNDERBAR opens up options to fix red. In this case, it added using.System.Diagnostic
            //Debug.Assert(b != 0, "B cannot be zero!"); //If this boolean condition fails, it will halt the program and throw up the string.
            //var tax = a / b;
            //Console.WriteLine(tax);
            //Console.ReadLine();

            //Build is usually the same thing as compile, sometimes with extra steps. Compile takes the source code, ensures it's runnable, and deploys.
            //Null reference
            //Security issues

            //var message = "Hello World"; 
            //var letter = "a"; //Char
            //var amount = 2.33m; //Double

            //Converting between data types
            //var stringPrice = Console.ReadLine();
            //var price = int.Parse(stringPrice);

            //int.Parse(price);
            //decimal.Parse(price);
            //DateTime.Parse(price); Takes the string representation and converts these to integers.

             //Converting a not-string into a string is special: ToString  

            var price = 2987987.343253464564576756753;
            Console.WriteLine(price);
            Console.ReadLine();
           
        }
    }
}
