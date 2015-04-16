using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._5
{
    public class Counter
    {
        public void CountWords()
        {
            //Take user input, split, and count array items.
            Console.WriteLine("Input a sentence for word count.");
            var input = Console.ReadLine();
            Debug.Assert(String.IsNullOrEmpty(input) == false, "You need to give me something here.");
            string[] splitInput = input.Split(' ');
            Console.WriteLine(splitInput.Length);           
            
            
           

            /*
            Console.WriteLine("Now please input a file path.");
            Console.ReadLine();
            var inputText = Console.ReadLine(); //"C:\Users\Monica\Desktop\ASP.NET Notes.txt"
            string text = System.IO.File.ReadAllText(@inputText);
            */


            //Split text pulled with ReadAllText and count the array items.
            string text = System.IO.File.ReadAllText(@"C:\Users\Monica\Desktop\ASP.NET Notes.txt");
            Debug.Assert(String.IsNullOrEmpty(text) == false, "You need to give a file path.");
            string[] splitText = text.Split(' ');
            Console.WriteLine("The number of words in this text document is (arguably): " + splitText.Length);


            /*
            Console.WriteLine("And finally, please input a URL.");
            Console.ReadLine();
            var inputURL = Console.ReadLine(); //"C:\Users\Monica\Desktop\ASP.NET Notes.txt"
            */


            //Split text pulled with Webclient's DownloadString method and count the array items.
            WebClient client = new WebClient();
            //string downloadString = client.DownloadString(@inputURL);
            string downloadString = client.DownloadString(@"https://www.google.com/");
            Debug.Assert(String.IsNullOrEmpty(downloadString) == false, "Needs a URL to work!");
            string[] splitPage = downloadString.Split(' ');
            Console.WriteLine("The number of words on this webpage is (roughly): " + splitPage.Length);
                       

            Console.ReadLine();
        }

        
    }












    //var splitted = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries); splits iterator Attribute the spaces and new lines, and removes extra spaces.




}
