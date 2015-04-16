using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Two
{
    class One
    {
        public int Add(int x, int y)
        {
            return x + y;
            //Implement a parameter array for an indeterminate number of values.
        }
    

    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        var thingy = new One();
          

    //        Debug.Assert(thingy.Add(2,3) != 5, "It's supposed to be 5!");
    //        Console.WriteLine("The sum is " + thingy.Add(2, 3).ToString());
    //    }


    class Crazy
    {
        public int DoSomething(int a, int b)
        {
            return a / b;
        }
        public int DoSomething(int a, int b, int c)
        {
            return a + b + c;
        }
        public int DoSomething(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }

    }




}




