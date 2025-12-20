using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Practice
    {


        public bool IsPalindrome(string s)
        {
            s.Replace(" ", "");
            char[] result = s.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != result[result.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }

}

