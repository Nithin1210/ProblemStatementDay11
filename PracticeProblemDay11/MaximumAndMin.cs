using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class MaximumAndMin
    {
        public void MaximumMinimum()
        {
            int max, min;
            Console.WriteLine("Length of array is : ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[length];
            Console.WriteLine("numbers in array is : ");
            for (int i = 0; i < length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = num[0];
            min = num[0];
            for (int i = 0; i < length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine("Maximum element : " + max);
            Console.WriteLine("Minimum element : " + min);
        }
    }
}
