using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailFenceCipher
{
    class RailFenceCipher
    { 
        public string Encode(string input, int rails)
        {
            string s = "";
            string[] arr = EncodeToArrey(input, rails);

            for (int i = 0; i <arr.Length; i++)            
                s += arr[i];
            
            return s;
        }        
            
        public string Decode(string input, int rails)
        {
            List<string> list = EncodeTextToList(input,rails);

            string decodeStr = "";
            int TapeIndex = 0;
            int addition = 1;

            for (int i = 0; i < input.Length; i++)
            {
                decodeStr += list[TapeIndex].First();
                list[TapeIndex] = list[TapeIndex].Remove(0, 1);
                TapeIndex += addition;

                ChangeSign(TapeIndex, rails, ref addition);
            }

            return decodeStr;
        }

        private List<string> EncodeTextToList(string input,int rails)
        {
            int[] TapesLength = EncodeToArrey(input, rails).Select(_=>_.Length).ToArray();

            List<string> list = new List<string>();
            int cur = 0;

            for (int i = 0; i < rails; i++)
            {
                string k = input.Substring(cur, TapesLength[i]);
                list.Add(k);
                cur += TapesLength[i];
            }            
            return list;
        }

        private string[] EncodeToArrey(string input,int rails)
        {
            string[] arr = new string[rails];
            int TapeIndex = 0;
            int addition = 1;

            for (int i = 0; i < input.Length; i++)
            {
                arr[TapeIndex] += input[i];
                TapeIndex += addition;

                ChangeSign(TapeIndex, rails, ref addition);
            }
            return arr;
        }

        private void ChangeSign(int i, int rails, ref int addition )
        {
            if (i == rails - 1 ||i == 0)            
                addition = -addition;            
        }
    }
}
