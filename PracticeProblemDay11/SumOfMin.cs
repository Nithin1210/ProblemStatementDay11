using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class SumOfMin
    {
        public void MinSum()
        {
            Console.WriteLine("Enter length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter the numbers in array");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int num1 = GetMin(arr);
            int[] arr2 = new int[length];
            for(int i=0;i<length;i++)
            {
                if (arr[i] == num1)
                {
                    arr2[i] = -1;
                }
                else
                {
                    arr2[i] = arr[i];
                }
            }
            int num2=GetMin(arr2);
            Console.WriteLine("The sum is "+num1+num2 );
        }
        public int GetMin(int[] arr)
        {
            int min = 0;
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min && arr[i]>=0)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
