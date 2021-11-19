using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the string you want");
            string ord = Console.ReadLine();
            string ans="";
            for (int i = 0; i < ord.Length; i++)
            {
                ans = ord[i] + ans;
            }
            Console.WriteLine("The reversed string is "+ans);
        }
    }
}