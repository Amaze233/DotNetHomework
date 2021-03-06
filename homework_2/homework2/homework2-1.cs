using System;

//编写程序输出用户指定数据的所有素数因子

namespace homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Input an integer: ");
            num = int.Parse(Console.ReadLine());
            findPrimeNumber(num);
        }

        static void findPrimeNumber(int num)
        {
            int temp = num; //将数据暂时存入temp
            for (int i = 2; i * i <= num; i++) //从素数2开始
            {
                if (temp % i == 0)
                {
                    Console.WriteLine(i); //当出现第一个素数是将其输出
                    while (temp % i == 0)
                    {
                        temp = temp / i; //将temp中除了i之外的因数赋值给temp
                    }
                    if (temp > 1)
                    {
                        Console.WriteLine(temp); //若是最后剩下的因数大于1则认为其也是一个素数因子
                    }
                }              
            }
        }
    }
}
