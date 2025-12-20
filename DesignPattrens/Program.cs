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
            //Console.WriteLine($"the result: {practice.TwoSum( new List<int> { -6, 7, 1, -7, 6, 2 }, 3 )}");
            string s = "Was it a car or a cat I saw?";
            Console.WriteLine($"the result: {practice.IsPalindrome(s)}");
            Console.ReadLine();
        }
    }
}
