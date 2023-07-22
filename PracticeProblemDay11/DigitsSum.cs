using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class DigitsSum
    {
        public void SumOfDigits()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int digit, sum = 0;
            while(num > 0)
            {
                digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits : "+sum);
        }
    }
}
