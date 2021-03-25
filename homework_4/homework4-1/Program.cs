//1、为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
//通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

using System;

namespace homwork_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            int[] array = {1, 2, 5, 6, 8, 9, 4, 3, 7};
            foreach (var num in array)
            {
                list.Add(num);  //将数组内容加入链表
            }

            int Max = list.GetHead.data;
            int Min = list.getTail.data;
            int sum = 0;

            list.Print(temp =>
            {
                Max = Math.Max(Max, temp);
                Min = Math.Min(Min,temp); 
                sum +=temp;
            });
            Console.WriteLine($"min: {Min}, max: {Max}, sum: {sum}");
        }
    }
}