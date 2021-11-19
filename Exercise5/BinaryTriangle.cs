using System;
using System.IO.Pipes;

namespace Exercise5
{
    public class BinaryTriangle
    {
        private int start = 1;

        public void Construct(int row)
        {
            for (int i = 0; i < row; i++)
            {
                string line = "";
                for (int j = 0; j <= i; j++)
                {
                    line = line + start;
                    start = start==1 ? 0 : 1;
                }
                Console.WriteLine(line);


            }
        }
    }
}