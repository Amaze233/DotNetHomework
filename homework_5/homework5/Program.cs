using System;

//写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、
//查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
//提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），
//订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。

//      要求：
//    （1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
//    （2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
//    （3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
//    （4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
//    （5） OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。

namespace homework5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("请选择想要进行的操作：\t 1.添加订单 \t 2.删除订单 \t 3.修改订单 \t 4.查询订单");
                int flag1 = Convert.ToInt32(Console.ReadLine());
                switch (flag1)
                {
                    case 1:
                        orderService.AddOrder();
                        break;
                    case 2:
                        
                        break;
                    default:
                        break;
                }
                Console.WriteLine("是否继续进行业务处理(Y/N)");
                if (Console.ReadLine() == "N")  flag = false;
            }
        }
    }
}