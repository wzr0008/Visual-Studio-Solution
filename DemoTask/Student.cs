using System;
using Microsoft.Extensions.Logging;

namespace DemoTask.Properties
{
    public class Student
    {
        string Name, Address; 
        int Mobile;

        public void GetDate()
        {
            Console.WriteLine("Enter your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number:");
            Mobile = Convert.ToInt32(Console.ReadLine());
        } 
        public void DisplayDate()
        {
            Console.WriteLine("Student Name:"+Name);
            Console.WriteLine("Stduent Address:"+Address);
            Console.WriteLine("Student Mobile"+Mobile);
        }
    }
}