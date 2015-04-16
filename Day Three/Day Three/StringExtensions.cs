using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Extensions //.Extensions puts it in a different namespace.
{
    static class StringExtensions //A STATIC CLASS IS A CLASS THAT ONLY HAS STATIC METHODS IN IT. STATIC METHODS ARE CALLED DIRECTLY FROM THE CLASS AND ARE ALWAYS IN THE MEMORY, SO THEY CAN BE USED DIRECT.
    {
        public static string Shout(this string input) //METHOD MUST BE STATIC BECAUSE ITS CLASS IS STATIC.
        {                         //This refers to the class being extended. This specifies which class is being extended.
            return input + "!";
        }
    }
}
