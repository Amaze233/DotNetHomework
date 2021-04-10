using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace homework5
{
    //订单服务类
    public class OrderService
    {
        //订单总列表
        public List<Order> OrdersList { get; set; }
        
        //查询订单是否存在
        public bool OrderExist(Order order)
        {
            return OrdersList.Contains(order);
        }
        
        //用于设定订单编号的计数
        private int idCount = 1;
        
        //添加订单
        public void AddOrder(Order order)
        {
            if (order == null)
            {
                Console.WriteLine("订单不存在！！");
            }

            order.Id = idCount;
            idCount++;
            OrdersList.Add(order);
        }

        public void AddOrder()
        {
            Order order = new Order();
            Console.WriteLine("请问是否开始添加订单（Y/N）");
            switch (Console.ReadLine())
            {
                case "Y":
                    //进行用户信息的添加
                    Console.WriteLine("请输入收货人信息 (ID name address phoneNumber):");
                    string line1 = Console.ReadLine();
                    string[] messages1 = line1.Split(' ');
                    
                    //新建用户
                    Client newClient = new Client(Int32.Parse(messages1[0]),messages1[1],messages1[2],Int32.Parse(messages1[3]));
                    order.Client = newClient;
                    
                    //新建订单明细列表
                    List<OrderDetails> newList = new List<OrderDetails>();
                    bool flag1 = true; //确认进行添加商品
                    while (flag1)
                    {
                        Console.WriteLine("请问是否继续添加商品（Y/N）");
                        string flag2 = Console.ReadLine();
                        switch (flag2)
                        {
                            case "Y":
                                //构建一个商品明细
                                //构建一个商品类型
                                Console.WriteLine("请输入商品信息 (name price)");
                                string line2 = Console.ReadLine();
                                string[] messages2 = line2.Split(' ');
                                    
                                //新建货物类型
                                Commodity newCommodity = new Commodity(messages2[0],Int32.Parse(messages2[1]));
                                
                                Console.WriteLine("请输入要购买的该商品的数量");
                                int amount = Convert.ToInt32(Console.ReadLine());
                                
                                //新建订单明细类型
                                OrderDetails newOrderDetails = new OrderDetails(newCommodity,amount,newClient);
                                newList.Add(newOrderDetails);
                                break;
                            case "N":
                                flag1 = false;
                                Console.WriteLine("商品添加完成");
                                break;
                        }
                    }
                    //将新建的订单明细列表加入订单
                    order.OrderDetailsList = newList;
                    
                    //将新订单加入订单总列表
                    OrdersList.Add(order);
                    Console.WriteLine("订单添加完成");
                    break;
                case "N":
                    Console.WriteLine("取消添加订单！！");
                    break;
            }
        }
        
        //删除订单
        public void DeleteOrder(Order order)
        {
            if (!OrderExist(order))
            {
                Console.WriteLine("订单不存在！！");
            }

            OrdersList.Remove(order);
        }
        
        //按编号查询订单
        public List<Order> Find(int id)
        {
            var query = OrdersList.Where(order => order.Id == id).
                OrderBy(order => order.TotalPrice);
            List<Order> list = query.ToList();
            return list;
        }
        
        //按照订单金额查询
        public List<Order> Query(double totalPrice)
        {
            var query = OrdersList.Where(s => s.TotalPrice == totalPrice)
                .OrderBy (s=>s.TotalPrice);
            List<Order> list = query.ToList();
            return list;
        }
        
        //修改订单
        public void ChangeOrder(Order order)
        {
            try
            {
                Console.WriteLine("请问您需要修改订单的什么信息？");
                Console.WriteLine("1:Customer \t 2:OrderList");
                int flag1 = Convert.ToInt32(Console.ReadLine());
                switch (flag1)
                {
                    //更改收货人信息
                    case 1:
                        Console.WriteLine("请输入更新后的收货人信息（name address phoneNumber）:");
                        string line1 = Console.ReadLine();
                        string[] messages1 = line1.Split(' ');
                        order.Client.Name = messages1[0];
                        order.Client.PhoneNumber = Int32.Parse(messages1[2]);
                        order.Client.Address = messages1[1];
                        break;
                    case 2:
                        Console.WriteLine("请输入要修改的商品的名称：");
                        string commodityName = Console.ReadLine();

                        for (int i = 0; i < order.OrderDetailsList.Count; i++)
                        {
                            if (order.OrderDetailsList[i].Commodity.Name == commodityName)
                            {

                                Console.WriteLine("请修改购买的该商品数量为:(0~n)");
                                int amount = Convert.ToInt32(Console.ReadLine());
                                if (amount == 0)
                                {
                                    //当商品数改为0时从订单详情表中删去改商品
                                    order.OrderDetailsList.RemoveAt(i);
                                }
                                else
                                {
                                    order.OrderDetailsList[i].Amount = amount;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "商品修改出错！！");
                throw;
            }

        }
        
    }
}