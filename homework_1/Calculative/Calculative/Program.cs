﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculative
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculative count = new Calculative(0, "+", 0);//实例化Calculative对象，默认第一个第二个数字为0，运算符为+号
            Console.SetWindowSize(100, 30);//设置控制台的大小
            Console.WriteLine("《简易计算器》");
            Console.WriteLine("\r\n请输入第一个要进行运算的数字");
            count.Number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\r\n请输入要进行运算的运算符,如：+、-、*、/……");
            count.Symbol = Console.ReadLine();
            Console.WriteLine("\r\n请输入第二个要进行运算的数字");
            count.Number2 = Convert.ToDouble(Console.ReadLine());
            count.resultn(count.Number1, count.Symbol, count.Number2);
        }

    }
}
