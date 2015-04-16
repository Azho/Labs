using Day_Three.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFantastic;
using Day3.Extensions;
using ArrayRandom;


namespace Day_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEW FOLDERS CREATE NEW NAMESPACES FOR CLASSES. You cannot reference classes in different namespaces. You have to import it (CTRL + .)
            
            //OUTPUT OF A  BUILD IS AN ASSEMBLY. IF YOU BRING THE EXE FILE TO ANOTHER MACHINE WITH .NET CAPABILITIES, THIS FILE WILL RUN.
            //1-1 CORRESPONDENCE BETWEEN PROJECTS AND ASSEMBLIES. EACH PROJECT GETS ITS OWN ASSEMBLY.
            //CLASS LIBRARY CREATES FUNCTIONALITY THAT CAN BE SHARED ACROSS APPLICATIONS.
            //BOLD NAME MEANS IT WILL RUN WHEN YOU DEBUG THE PROGRAM. RIGHT CLICK TO CHANGE THIS.
            //TO REFERENCE SOMETHING LIKE A METHOD IN ANOTHER NAMESPACE; RIGHT CLICK REFERENCE UDER THE PROJECT, ADD REFERENCE, AND FIND THE PROJECT UNDER SOLUTION.
            //ADDING A REFERENCE TO A PROJECT TELLS THE CURRENT PROJECT TO USE THE ASSEMBLY COMPILED UNDER A DIFFERENT PROJECT.
 
            //TWO TYPES OF ASSEMBLIES: 
                //GAC (GLOBAL ASSEMBLY CACHE) STORES COMMON CLASSES THAT ANYONE CAN ACCESS
                    //C > Widows > Microsoft.NET > Framework > current version: THE GAC
                //NORMAL ASSEMBLIES THAT ARE NOT PUT INTO THE GAC 

            //5 ACCESS MODIFIERS IN .NET
                //PUBLIC: Accessible anywhere
                //PRIVATE: Accessible in same class
                //PROTECTED: Accessible in a derived class
                //INTERNAL: Accessible in same assembly
                //PROTECTED INTERNAL: Accessible in same assembly or class outside of assembly in a class that derives from the class in the assembly.
            
            //EXTENTION METHOD
            //POLYFILL: A thing in JavaScript that lets you modify older version methods to act like newer ones. You can literally add stuff in.
            //YOU CAN ADD METHODS ONTO A CLASS AT RUNTIME IN JAVASCRIPT.
            //C# DOES THAT WITH EXTENTION METHOD: Add new functionality (method) to an existing class at runtime.
            //&lt; = less than, &gt; = greater than. HTML encoding that lets you add tags without someone else being able to put bad stuff in.
                //var userComment = "adfjflsjk"
                //var encoder = new HtmlUtility();
                //var encodedComment = encoder.HtmlEncode(userComment);
            //==========
            //var encodedComment = &lt;phrase here&gt;.ToHtmlEncoded();


            
            /*SHOUT: Adds exclamation to any string.
            Console.WriteLine("This is great".Shout());
            Console.ReadLine();
            */

            //Create an extension method named GetRandom() that extends the Array class that randomly returns 1 headline from the array. You should call the 
            //GetRandom() method like this: Console.WriteLine( newsArray.getRandom() );

            var newsArray = new string[]
            {
                "Bookstores Making A Comeback! Kindle Readers In Hiding!",
                "Toddler Devoured By Large Budgie!",
                "Blue Skies In Seattle! Locals Protesting Against Vitamin D!"
            };

            Console.WriteLine(newsArray.GetRandom());
            Console.ReadLine();

        }
    }
}
