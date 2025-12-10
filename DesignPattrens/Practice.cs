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
        
          public List<List<string>> GroupAnagrams(string[] strs)
        {

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            foreach (var s in strs)
            {

               var chars= s.ToCharArray();
                Array.Sort(chars);
                var key = new string(chars);

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                map[key].Add(key);

            }

            return map.Values.ToList();



        }

    }

}

