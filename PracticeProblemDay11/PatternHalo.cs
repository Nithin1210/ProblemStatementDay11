using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class PatternHalo
    {
        public void PrintPattern()
        {
            Console.WriteLine("Enter length of the pattern");
            int length = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    if (i == 0 || i == length - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if(j == 0 || j == length - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
