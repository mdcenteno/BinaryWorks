using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryWorksConsoleApp
{
    public class BinaryWorks
    {
        public string ToBinary(int val)
        {
            //Console.Write(val + " - ");
            string output = "";
            do
            {
                int resto = val % 2;
                output = resto.ToString() + output;
                val = val / 2;
            } while (val > 0);
            //Console.WriteLine(output);
            return output;
        }

        public int ToDecimal(string binary)
        {
            int output = 0;
            binary = new string(binary.Reverse().ToArray());
            //Console.WriteLine(binary);
            int mag = 1;

            foreach (char alg in binary)
            {
                //Console.WriteLine($"{alg} - {mag}");
                output += mag * int.Parse(alg.ToString());
                mag = mag * 2;
            }
            //Console.WriteLine(output);
            return output;
        }

        public int Cardinality(string binary, char alg)
        {
            int card = 0;
            foreach (char c in binary)
            {
                if (c == alg)
                {
                    card++;
                }
            }
            return card;
        }
    }
}
