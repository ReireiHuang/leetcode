using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Solution
    {
        public int RemoveDuplicates(int[] nums = null)
        {
            int count = 1;
            if (nums.Length > 1)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == nums[count - 1])
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
