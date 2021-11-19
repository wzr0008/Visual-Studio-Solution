using System;

namespace Exerciese6
{
    public class Triangle
    {
        public void Construct(int row)
        {
            for (int i = 0; i < row; i++)
            {
                string line = "";
                for (int j = row - 1; j >= 0; j--)
                {
                    if (j > i)
                    {
                        line += " ";
                    }
                    else
                        line += "*";
                }

                for (int j = 1; j <row; j++)
                {
                    if (j > i)
                        line += " ";
                    else
                    {
                        line += "*";
                    }
                }
                Console.WriteLine(line);
                ;
            }
            for (int i = row-2; i >=0; i--)
            {
                string line = "";
                for (int j = row - 1; j >= 0; j--)
                {
                    if (j > i)
                    {
                        line += " ";
                    }
                    else
                        line += "*";
                }

                for (int j = 1; j <row; j++)
                {
                    if (j > i)
                        line += " ";
                    else
                    {
                        line += "*";
                    }
                }
                Console.WriteLine(line);
                ;
            }
        }
    }
}