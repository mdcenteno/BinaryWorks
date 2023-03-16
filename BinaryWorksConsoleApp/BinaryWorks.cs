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

        public int Cardinality(string bNum, char alg)
        {
            int card = 0;
            foreach (char c in bNum)
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
