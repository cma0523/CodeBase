using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// StudentDiscount
    /// </summary>
    public class StudentDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("Student tickets：");
            return price * 0.8;
        }
    }

    /// <summary>
    /// VIPDiscount
    /// </summary>
    public class VIPDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("VIP ticket：");
            Console.WriteLine("Points Added！");
            return price * 0.5;
        }
    }

    /// <summary>
    /// 具体策略类：儿童票折扣ChildrenDiscount
    /// </summary>
    public class ChildrenDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("Children ：");
            return price - 10;
        }
    }
}
