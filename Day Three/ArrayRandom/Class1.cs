using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ArrayRandom
{
    public static class RandomArray
    {
        public static string GetRandom(this string[] result)
        {
            var random = new Random();
            return result[random.Next(result.Length)];
            //return result[new Random().Next(result.Length)];
        }
    }
}
