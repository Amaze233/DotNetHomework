using System;

//编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和


namespace homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = inputArray();
            int max, min, sum;
            double avg;
            getArray(array,out max,out min,out avg,out sum);
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Avg = {avg}"); 
            Console.WriteLine($"Sum = {sum}");
        }
        //输入数组
        static int[] inputArray()
        {
            int num;
            Console.WriteLine("Please input array size: ");
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Please input the array: ");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
        static void getArray(int[] arr,out int max, out int min, out double avg,out int sum)
        {
            int i;
            max = min = arr[0];
            sum = 0;
            for(i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if(max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            avg = (double)(sum/arr.Length);
        }
    }
}
