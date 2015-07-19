using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// start namespace MultiplicationTables
namespace MultiplicationTables
{
    /// <summary>
    /// This program will calculate and display a multiplication table.
    /// </summary>
    
    // start class Program
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("\n");

                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,6}", i * j);
                }
            }
            Console.Read();
        }// end main method
    }// end class Program
}// end namespace MultiplicationTables