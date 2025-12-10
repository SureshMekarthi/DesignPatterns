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

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = 1;
                }
                else
                {
                    map[nums[i]]++;
                }
            }

           int[] result = map.Where(kv => kv.Value >= k)
                            .OrderByDescending(kv => kv.Key)
                            .Select(kv => kv.Key)
                            .ToArray();

            return result;
        }

    }

}

