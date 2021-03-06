using System;

//  用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，
//  再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数。

namespace homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the size ： ");
            int size = int.Parse(Console.ReadLine());
            findPrimeNumber(size);
        }

        static void findPrimeNumber(int n)
        {
            //先构建一个大小为n的数组，代表其间的数
            int[] array = new int[n+1];
            /*for (int i = 2; i <= n; i++)
            {
                array[i] = i;
            }
            */
            for (int i = 2; i*i <= n; i++)
            {
                for (int j = i*i; j < n; j+=i) //按i的倍数进行查验
                {
                    if(j % i == 0) //若是j+min能被整除则将数组对应位置设为1
                    {
                        array[j] = 1;
                    }
                }
            }
            Console.WriteLine("The prime number between min and max is: ");
            for (int i = 2; i < n; i++)
            {
                if(array[i] != 1)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
