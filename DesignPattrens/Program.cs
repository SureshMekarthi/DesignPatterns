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
            TapWaterProblem tapWaterProblem = new TapWaterProblem();
            //Console.WriteLine($"the result: {practice.TwoSum( new List<int> { -6, 7, 1, -7, 6, 2 }, 3 )}");
            string s = "Was it a car or a cat I saw?";
            // Console.WriteLine($"the result: {practice.MaxArea(new int[] { 1, 7, 2, 5, 4, 7, 3, 6 })}");

            Console.WriteLine($"the result: {tapWaterProblem.Trap(new int[] { 0, 2, 0, 3, 1, 0, 1, 3, 2, 1 })}");
            Console.ReadLine();
        }
    }
}
