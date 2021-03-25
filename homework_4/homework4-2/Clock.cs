using System.Threading;
using System;

namespace homework4_2
{
    //定义事件处理函数
    public delegate void TickHandler(Object sender, TickClock args);

    public delegate void AlarmHandler(Object sender,TickClock args1,AlarmClock args2);
    //定义参数类
    public class TickClock
    {
        public string nowTime => DateTime.Now.ToString("T");
    }
    public class AlarmClock {
        public AlarmClock(string alarmTime)
        {
            this.alarmTime = alarmTime;
        }
        public string alarmTime { get; set; }
    }
   
    public class Clock { 
    
        //声明事件
        public event TickHandler TickClock;
        public event AlarmHandler AlarmClock;
        
        //触发事件
        public void onClock()
        {
            TickClock args1 = new TickClock();

            AlarmClock args2 = new AlarmClock("19:56:00");
            
            TickClock(this, args1);
            AlarmClock(this, args1,args2);
        }
    }

    public class Form
    {
        public Clock clock = new Clock();

        public Form()
        {
            clock.TickClock += clock1;
            clock.AlarmClock += clock2;
        }

        void clock1(Object sender,TickClock args)
        {
            Console.WriteLine("现在时间是："+ args.nowTime);
        }
        void clock2(Object sender,TickClock args1,AlarmClock args2)
        {
            if (args1.nowTime == args2.alarmTime)
            {
                Console.WriteLine("闹钟响了");
            }
            
            Thread.Sleep(1000);
        }
        
    }
}