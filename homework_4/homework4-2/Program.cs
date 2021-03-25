//2、  使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//      在闹钟走时时或者响铃时，在控制台显示提示信息。

namespace homework4_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Form form = new Form();

            while (true)
            {
                form.clock.onClock();
            }
        }
    }
}