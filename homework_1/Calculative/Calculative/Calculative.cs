using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculative
{
    class Calculative
    {
        //定义的成员变量
        private double number1;
        private double number2;
        private string symbol;
        private double sum = 0;

        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Symbol
        {
            get { return symbol; }
            set
            {
                if (value == "+" || value == "-" || value == "*" || value == "/" || value == "%")
                {
                    symbol = value;
                }
                else
                {
                    Console.WriteLine("您输入的运算符不在范围内，请重新输入");
                    this.Symbol = Console.ReadLine();
                }
            }
        }

        //构造函数    
        public Calculative(double number1, string symbol, double number2)//初始化成员变量
        {

            this.Number1 = number1;
            this.Symbol = symbol;
            this.Number2 = number2;
        }


        //输出运算结果
        public void resultn(double number1, string symbol, double number2)
        {
            switch (symbol)
            {
                case "+":
                    sum = number1 + number2;
                    Console.WriteLine("\r\n计算公式及结果为： " + "{0}+{1}={2}", number1, number2, sum);
                    break;
                case "-":
                    sum = number1 - number2;
                    Console.WriteLine("\r\n计算公式及结果为： " + "{0}-{1}={2}", number1, number2, sum);
                    break;
                case "*":
                    sum = number1 * number2;
                    Console.WriteLine("\r\n计算公式及结果为： " + "{0}*{1}={2}", number1, number2, sum);
                    break;
                case "/":
                    sum = number1 / number2;
                    Console.WriteLine("\r\n计算公式及结果为： " + "{0}÷{1}={2}", number1, number2, sum);
                    break;
                case "%":
                    sum = number1 % number2;
                    Console.WriteLine("\r\n计算公式及结果为： " + "{0}%{1}={2}", number1, number2, sum);
                    break;
            }
            Console.ReadLine();
        }


    }
}

