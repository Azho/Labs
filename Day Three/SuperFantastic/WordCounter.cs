using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFantastic
{
    public class WordCounter
    {
        private int CountWords(string words)
        {
            return words.Split().Length;
        }
    }
}

//YOU CAN MIX ACCESSIBILITY STATES. PUBLIC CLASS, PRIVATE METHOD.
//PRIVATE IS DEFAULT. IF YOU DON'T SET ACCESS MODIFIERS, YOU CAN ONLY ACCESS THE CLASS IN THE SAME CLASS.