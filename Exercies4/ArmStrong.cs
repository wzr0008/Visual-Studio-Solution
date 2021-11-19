using System;
using System.Collections.Generic;
namespace Exercies4
{
    public class ArmStrong
    {
        public List<int> check(int a, int b)
        {
            List<int> ans = new List<int>();
            for (int i = a; i <= b; i++)
            {
                int val = i;
                int sum = 0;
                while (val >0)
                {
                    int ind = val % 10;
                    sum += (int) Math.Pow(ind, 3);
                    val/= 10;
                }
                if(sum==i)
                    ans.Add(i);
            }

            return ans;
        }
    }
}