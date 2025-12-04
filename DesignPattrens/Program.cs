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
            Console.WriteLine($"the result: {practice.MinSubArrayLen(5, new int[] { 2, 3, 1, 1, 1, 1, 1 })}"); 
            Console.ReadLine();
        }
    }
}
