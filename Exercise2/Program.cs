using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Exercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Arithmetic test = new Arithmetic();
            test.Addition(1,2);
            test.Subtraction(1,3);
            test.Multiplication(3,4);
            test.Division(4,5);
        }

       
    }
}