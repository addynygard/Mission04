using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission04
{
    internal class Receives
    {
        public static void ReceiveArray(string[] choices)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                Console.Write(choices[i]);

                if ((i +1) % 3 != 0)
                {
                    Console.WriteLine("|");
                }
                else
                {
                    Console.WriteLine();
                    if (i < choices.Length - 1)
                    {
                        Console.WriteLine("-----");
                    }
                }
            }
        }
    }
}
