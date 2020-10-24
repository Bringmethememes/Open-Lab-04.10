using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float a = 0;
            for (int i = 0; i < nums.Length ; i++)
            {
                a = a + nums[i];
                
            }
            float bruh = a / nums.Length;
            return bruh;
            






        }



    }
}
