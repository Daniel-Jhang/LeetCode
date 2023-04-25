using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] TwoSum(int[] nums, int target)
            {
                int temp = 0;
                int[] result = new int[0];
                for (int i = 0; i < nums.Length; i++)
                {
                    temp = nums[i] + nums[i + 1];
                    if (temp == target)
                    {
                        result = [i, i + 1];
                        return result;
                    }
                }
                return result;
            }
        }
    }
}
