using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class UniqueElements
    {
        public void UniqueInArray()
        {
            int count = 0;
            Console.WriteLine("Enter length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter the numbers in array");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Unique Elements");
            for (int i = 0;i < length; i++)
            {
                count = 0;
                int num = arr[i];
                for(int j = 0; j < length; j++)
                {
                    if (num == arr[j])
                    {
                        count++;
                    }
                }
                if(count==1)
                {
                    Console.WriteLine(num);
                }
            }
        }
         
    }
}

