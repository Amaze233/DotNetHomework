using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderSystemTest
{
    //订单服务类
    public class OrderService : IEnumerable<Order>
    {
        //订单列表
        public List<Order> Orders { get; private set; } = new List<Order>();

        //添加订单
        public int AddOrder(Order order)
        {
            if (order == null)
            {
                throw new NullArgumentException();
            }
            if (Exists(order))
            {
                throw new OrderExistException();
            }
            order.Id = idCounter;
            idCounter++;
            Orders.Add(order);
            return order.Id;
        }

        //查询订单是否存在
        public bool Exists(Order order) => Orders.Contains(order);

        //id查询订单
        public bool Exists(int id) => Orders.Find(order => order.Id == id) != null;

        //id删除订单
        public void RemoveOrder(int id)
        {
            int rmCnt = Orders.RemoveAll(order => order.Id == id);
            if (rmCnt == 0)
            {
                throw new OrderNotExistException();
            }
        }

        //删除订单
        public void RemoveOrder(Order order)
        {
            if (!Exists(order))
            {
                throw new OrderNotExistException();
            }
            Orders.Remove(order);
        }

        //id获取订单
        public Order Get(int id)
        {
            return Orders.Find(order => order.Id == id);
        }

        public IEnumerator<Order> GetEnumerator()
        {
            foreach (Order order in Orders)
            {
                yield return order;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void ForEach(Action<Order> action)
        {
            foreach (Order order in Orders)
            {
                action?.Invoke(order);
            }
        }


        //订单编号
        private int idCounter = 0;

        public void Export(string filePath)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xs.Serialize(fs, this.Orders);
            }
            Console.WriteLine("序列化：");
            Console.WriteLine(File.ReadAllText(filePath));
        }
        public void Import(string filePath)
        {
            Orders.Clear();
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                Orders = (List<Order>)xs.Deserialize(fs);
                Console.WriteLine("反序列化：");
                foreach (Order order in Orders)
                {
                    Console.WriteLine(order);
                }
            }
        }


    }



    /// <summary>
    /// 订单已存在，在添加订单时抛出
    /// </summary>
    public class OrderExistException : ApplicationException
    { }

    /// <summary>
    /// 订单不存在，在删除时抛出
    /// </summary>
    public class OrderNotExistException : ApplicationException
    { }
}