using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            original = "abcd";            
            original.Replace("a", "aa");
            original.Replace("b", "bb");
            original.Replace("c", "cc");
            original.Replace("d", "dd");
            return original;
        }
       
    }
}
