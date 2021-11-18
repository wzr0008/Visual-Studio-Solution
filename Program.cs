using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CAssignment cAssignment = new CAssignment();
            int[] cur = new int[] {1, 2, 3,4};
            int[] result = cAssignment.duplicate(cur);
            foreach(int val in result)
                Console.WriteLine(val);
        }

       
    }
}