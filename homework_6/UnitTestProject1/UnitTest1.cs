using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        var service = new OrderService();

        [TestMethod]
        public void TestMethod1()
        {
            var client1 = new Client("小明", 123456789);
            var client2 = new Client("小洪", 156789324);
            var client3 = new Client("杜克", 147852369);

            var commodity1 = new Commodity("鸡蛋", 2);
            var commodity2 = new Commodity("西红柿", 4);
            var commodity3 = new Commodity("洋葱", 2.5);

            string address1 = "北京";
            string address2 = "上海";
            string address3 = "武汉";

            var details1 = new List<OrderDetail>();
            details1.Add(new OrderDetail(address1, commodity1, 5));
            details1.Add(new OrderDetail(address1, commodity3, 2));

            var details2 = new List<OrderDetail>();
            details2.Add(new OrderDetail(address2, commodity2, 10));
            details2.Add(new OrderDetail(address2, commodity1, 20));
            details2.Add(new OrderDetail(address2, commodity3, 5));

            var details3 = new List<OrderDetail>();
            details3.Add(new OrderDetail(address3, commodity1, 30));

            var order1 = new Order(client1, details1);
            var order2 = new Order(client2, details2);
            var order3 = new Order(client3, details3);

            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);

            //用 LINQ 语法查询
            var result = from order in service
                         where order.SumPrice > 10
                         orderby order.Id
                         select order;
            foreach (var order in result)
            {
                Console.WriteLine(order);
                Console.WriteLine("---------------------------------");
            }
        }

        [TestMethod]
        public void Export()
        {
            TestMethod1();
            service.Export("test.xml");
        }

        [TestMethod]
        public void Import()
        {
            TestMethod1();
            service.Import("test.xml");
        }
    }
}
