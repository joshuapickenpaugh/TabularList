//Joshua Pickenpaugh
//July 28, 2017
//Tabular Looping (Page 184, "Visual C# 2012"). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabularLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 1; x++)
            {
                Console.Write("N ");
                for (int y = 10; y < 1001; y *= 10)
                {
                    Console.Write(y + "*N ");
                }                
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int x = 1; x < 6; x++)
            {
                Console.Write(x + " ");
                for (int y = (x * 10); y < (x * 1001); y *= 10)
                {
                    Console.Write(y + "   ");                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
