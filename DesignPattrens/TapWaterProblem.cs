using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class TapWaterProblem
    {
        //0, 2, 0, 3, 1, 0, 1, 3, 2, 1
        public int Trap(int[] height)
        {
            int left = 0; int right = height.Length - 1;
            int maxLeft = height[left]; int maxRight = height[right];
            int result = 0;
            while (left < right)
            {
                if (maxLeft < maxRight)
                {
                    left++;
                    maxLeft = Math.Max(maxLeft, height[left]);
                    result = result + maxLeft - height[left];
                }
                else
                {
                    right--;
                    maxRight = Math.Max(maxRight, height[right]);
                    result = result + maxLeft - height[right];
                }
            }
            return result;
        }
    }

}
