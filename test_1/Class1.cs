using System;
using Test_1;
namespace Test_2
{
    public class Class2
    {
        static void Main()
        {
            double result;
            double x, y;
            Console.WriteLine("请输入第一个数:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数:");
            y = Convert.ToInt32(Console.ReadLine());
            Caculate cal = new Caculate();
            result = cal.Add(x, y);
            Console.WriteLine($"计算结果为：{result }");
            result = cal.Min(x, y);
            Console.WriteLine($"计算结果为：{result }");
            result = cal.Mul(x, y);
            Console.WriteLine($"计算结果为：{result }");
            result = cal.Div(x, y);
            Console.WriteLine($"计算结果为：{result }");
        }
    }
}

