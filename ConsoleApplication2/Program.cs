using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 背景颜色
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            // 清除屏幕、延迟
            Console.Clear();
            System.Threading.Thread.Sleep(1000);

            // 显示画面
            Console.WriteLine("╔═════════╗");
            Console.WriteLine("║     大乐透机     ║");
            Console.WriteLine("╚═════════╝");

            // 宣告list
            List<int> numbers = new List<int>();

            // 在number里放入数字
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }

            // 产生乱数
            Random rand = new Random();

            // 循环
            for (int i = 0; i < 6; i++)
            {
                // 用物件产生乱数
                int r = rand.Next(1, numbers.Count);

                // 显示
                Console.WriteLine(numbers[r] + " ");

                // 从list删除
                numbers.RemoveAt(r);
            }

            Console.ReadLine();
        }
    }
}
