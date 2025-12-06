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


        public int SubarraySum(int[] nums, int k)
        {
            int currentSum = 0;
            int resultCount = 0;

            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic[0] = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum = currentSum + nums[i];
                int excludedSum = currentSum - k;
                if (dic.ContainsKey(excludedSum))
                {
                    resultCount = resultCount + dic[excludedSum];
                }
                if (dic.ContainsKey(currentSum))
                {
                    dic[currentSum]++;
                }
                else
                {
                    dic[currentSum] = 1;
                }
            }
            return resultCount;
        }
    }
}
