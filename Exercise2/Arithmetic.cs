using System;

namespace Exercise2
{
    public class Arithmetic
    {
        public void Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"The sum between {a} and {b} is {sum}.");
            return;
        }

        public void Subtraction(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine($"The substraction between {a} and {b } is {sub}.");
        }

        public void Multiplication(int a, int b)
        {
            int mult = a * b;
            Console.WriteLine($"The multiplication between {a} and {b} is {mult}");
        }

        public void Division(int a, int b)
        {
            int div = a / b;
            Console.WriteLine($"The division between {a} and {b} is {div}");
        }
    }
}