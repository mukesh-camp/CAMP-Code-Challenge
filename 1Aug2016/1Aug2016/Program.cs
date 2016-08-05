using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Aug1st2016
{
    // ReSharper disable once InconsistentNaming
    public class ProgramAug1st2016
    {
        public static void Main(string[] args)
        {
            var inputValues = Console.ReadLine();
            if (inputValues != null)
            {
                var elements = inputValues.Split(',');
                if (elements.Length > 100000)
                {
                    Console.WriteLine("No of elements can not exceed 100000");
                    return;
                }
                var numbers = Array.ConvertAll(elements, Int32.Parse);
                var result = CheckTotal(numbers);
                Console.WriteLine(result ? "TRUE" : "FALSE");
           }
        }

        public static bool CheckTotal(int[] nums)
        {
            var leftIndex = 0;
            var rightIndex = nums.Length - 1;

            var leftTotal = nums[leftIndex];
            var rightTotal = nums[rightIndex];

            while (leftIndex != rightIndex)
            {
                if (leftTotal < rightTotal)
                {
                    leftIndex++;
                    leftTotal += nums[leftIndex];
                }
                else if (leftTotal > rightTotal)
                {
                    rightIndex--;
                    rightTotal += nums[rightIndex];
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
