using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == val)
                        continue;
                    nums[count] = nums[i];
                    count++;
                }
                return count;
            }
            return nums.Length;
        }
    }
}
