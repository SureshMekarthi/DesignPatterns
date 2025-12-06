using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice practice = new Practice();
            Console.WriteLine($"the result: {practice.mostFrequentElement( new int[] { 2, 3, 1, 2, 4, 3 })}"); 
            Console.ReadLine();
        }
    }
}
