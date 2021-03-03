using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 封装
{
    class Calculative
    {
        #region 定义的成员变量
        private double number1;
        private double number2;
        private string symbol;
        private double sum = 0;
        #endregion

        #region 构造函数    
        public Calculative(double number1, string symbol, double number2)//初始化成员变量，默认第一个第二个数字为0，运算符为+号
        {

            this.Number1 = number1;
            this.Symbol = symbol;
            this.Number2 = number2;
        }
        #endregion

        #region 运算过程
        public void resultn(double number1, string symbol, double number2)
        {
            switch (symbol)
            {
                case "+": sum = number1 + number2; 
                          Console.WriteLine("\r\n计算公式及结果为： " + "{0}+{1}={2}", number1, number2, sum);
                          break;
                case "-": sum = number1 - number2;
                          Console.WriteLine("\r\n计算公式及结果为： " + "{0}-{1}={2}", number1, number2, sum); 
                          break;
                case "*": sum = number1 * number2; 
                          Console.WriteLine("\r\n计算公式及结果为： " + "{0}*{1}={2}", number1, number2, sum);
                          break;
                case "/": sum = number1 / number2; 
                          Console.WriteLine("\r\n计算公式及结果为： " + "{0}÷{1}={2}", number1, number2, sum); 
                          break;
                case "%": sum = number1 % number2; 
                          Console.WriteLine("\r\n计算公式及结果为： " + "{0}%{1}={2}", number1, number2, sum); 
                          break;
            }
            Console.ReadLine();
        }
        #endregion

        #region 封装的属性
        public double Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        
        public double Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
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
        #endregion

    }
}

