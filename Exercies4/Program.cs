using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Exercies4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArmStrong element = new ArmStrong();
            Console.WriteLine("Please input the value of a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            List<int> res = element.check(a, b);
            Console.WriteLine(res.Count);
            foreach(int val in res)
                Console.WriteLine("ArmStrong num is "+val);
        }

       
    }
}