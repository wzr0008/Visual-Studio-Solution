using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Exerciese6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Please Enter Number Of Rows");
            int row = Convert.ToInt32(Console.ReadLine());
            triangle.Construct(row);
            ;
        }

       
    }
}