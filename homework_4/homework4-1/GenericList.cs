using System;
using System.Runtime.Remoting.Messaging;

namespace homwork_4
{
    //结点类
    public class Node<T>
    {
        public Node<T> next { get; set; }
        public T data { get; set; }

        public Node(T t)
        {
            data = t;
            next = null;
        }
    }
    //泛型链表 
    public class GenericList<T>
    {
        //头结点和尾节点
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        public Node<T> GetHead
        {
            get => head;
        }

        public Node<T> getTail
        {
            get => tail;
        }

        public void Print(Action<T> action)
        {
            Node<T> node = head;
            while (node != null)
            {
                action(node.data);
                node = node.next;
            }
        }
    }
}