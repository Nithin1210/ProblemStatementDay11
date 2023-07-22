using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class PatternTriangle
    {
        public void PrintPattern()
        {
            Console.WriteLine("Enter length of pattern");
            int length = Convert.ToInt32(Console.ReadLine());   
            for(int i = length-1; i>=0;i--)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
