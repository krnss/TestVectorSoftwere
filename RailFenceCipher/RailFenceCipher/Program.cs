
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailFenceCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "WEAREDISCOVEREDFLEEATONCE";
            int rails = 3;

            RailFenceCipher rfc = new RailFenceCipher();

            string encode = rfc.Encode(example, rails);
            string decode = rfc.Decode(encode, rails);

            Console.WriteLine(encode);
            Console.WriteLine(decode);
            Console.WriteLine(example);

            Console.ReadLine();
        }        
    }
}
