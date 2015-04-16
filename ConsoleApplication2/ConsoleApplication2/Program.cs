using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the class
            var rnd = new Random();
            //Random rnd = new Random(); An older metho of doing the same thing.
            //^ Another way of doing the same thing. IMPLICIT INFERENCE figures out the data type at compile time rather than run time.
            //Variants (not variables) can cause a performance skip. What is a performance skip?
            var result = rnd.Next(100); //Gives 0-99
            Console.WriteLine("The random number is " + result);
            Console.ReadLine(); //Pause 

            //Syntax for var vs. Console is different because var is C# but Console and Random are from .NET classes.
            //***We cannot combine static and instant methods. Next is an instance because it has to remember the previous value taken. So we can't write: var result = Random.Next(100);
            //Because C# is a static language where everything must be known and declared at compile time, you cant reassign a variable as a different data type even though you can do it in JavaScript.

        }
    }
}
