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
        //{-2,-2,-1,-1,0,0,2,2})
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            Array.Sort(nums);

            int n = nums.Length;

            for (int i = 0; i < n - 2; i++)
            {
                int j = i + 1; int k = n - 1;
                if(i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                if(nums[i] > 0)
                {
                    break;
                }
                
                int sum = nums[i] + nums[j] + nums[k];
                while (j < k)
                {
                    if (sum > 0)
                    {
                        k--;
                    }
                    else if (sum < 0)
                    {
                        j++;
                    }
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                    }
                }

            }
            return result;

        }
    }
}

