using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DemoTask.Properties;
namespace DemoTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.GetDate();
            S1.DisplayDate();
            Console.ReadKey();
        }
    }
}