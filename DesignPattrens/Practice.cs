using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Practice
    {
        //public int SubarraySum(int[] nums, int k)
        //{

        //    int key = 0;
        //    int result = 0;
        //    Dictionary<int, int> dic = new Dictionary<int, int>();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int sum = 0;
        //        for (int j = i; j < nums.Length; j++)
        //        {
        //            sum = sum + nums[j];
        //            dic[key] = sum;
        //            key++;
        //        }
        //    }
        //    foreach (int num in dic.Values)
        //    {
        //        if (num == k)
        //        {
        //            result++;
        //        }

        //    }
        //    return result;
        //}

        public int MinSubArrayLen(int target, int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    sum = sum + nums[j];

                    if (dic.ContainsKey(sum))
                    {
                        if (dic[sum] > j - i + 1)
                        {
                            dic[sum] = j - i + 1;
                        }
                    }
                    else
                    {
                        dic[sum] = j - i + 1;
                    }
                }
            }

            foreach (var sum in dic.Keys)
            {
                if (sum >= target)
                {
                    if(result == 0)
                    {
                        result = dic[sum];
                    }
                    else if (result > dic[sum])
                    {
                        result = dic[sum];
                    }
                }
            }
            return result;
        }
    }
}
