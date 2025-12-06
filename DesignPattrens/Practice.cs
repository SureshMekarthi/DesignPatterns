using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Practice
    {
        public int mostFrequentElement(int[] nums)
        {
           // int resultNum = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = map[nums[i]] + 1;
                }
                else
                {

                    map[nums[i]] = 1;
                }
            }

            var keyvalue= map.OrderByDescending(x=>x.Value).First();
            return keyvalue.Key;
        }


    }
}
