using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class DuplicateElements
    {
        public void DuplicateInArray()
        {
            int count = 0;
            Console.WriteLine("Enter length of array");
            int length = Convert.ToInt32(Console.ReadLine());   
            int[] arr = new int[length];
            int[] temp = new int[length];
            Console.WriteLine("Enter the numbers in array");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < length-1;i++)
            {
                int num = arr[i];
                if (!IsPresent(num, temp))
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (arr[j] == num)
                        {
                            count++;
                            temp.Append(num);
                        }
                    }
                }
            }
            Console.WriteLine("Duplicates : "+count);
        }
        public bool IsPresent(int num, int[] array1)
        {
            for(int i = 0 ; i < array1.Length ; i++)
            {
                if (array1[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
