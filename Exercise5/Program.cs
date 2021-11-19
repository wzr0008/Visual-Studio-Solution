using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Exercise5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTriangle binaryTriangle = new BinaryTriangle();
            Console.WriteLine("Enter the Number of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            binaryTriangle.Construct(row);
            return;
        }
        
    }
}