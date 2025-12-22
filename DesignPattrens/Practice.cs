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
      //{ 1, 7, 2, 5, 4, 7, 3, 6 }
        public int MaxArea(int[] heights)
        {

            int left = 0; int right = heights.Length - 1;
            int max = 0;

            while (left < right)
            {
                int width = right - left;
                int hight = Math.Min(heights[left], heights[right]);
                int area = width * hight;

                if (heights[left] < heights[right])
                {
                    left++;
                }
                else if (heights[left] > heights[right])
                {
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
                max = Math.Max(max, area);
            }
            return max;

        }
    }
}

