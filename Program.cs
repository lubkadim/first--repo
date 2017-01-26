using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int len = 1;
            int bestLen = 1;
            int bestStart = 1;
            for (int pos = 1; pos <= nums.Length - 1; pos++)
            {
                if (nums[pos] == nums[pos - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;                      
                       
                    }
                }
                else
                {
                    start = pos;
                    len = 1;
                }

            }
            for (int i =bestStart; i <bestStart+bestLen; i++)
            {
                Console.Write("{0} ",nums[i]);
            }
            

        }
    }
}
