using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let`s Do This!");
            Console.WriteLine("I am going to call my son.");
            var asyncService = new AsyncService();
            asyncService.AsyncTask();//调用Async修饰的方法
            Console.WriteLine("My son is busy now,and I will go on.");
            Console.WriteLine("I`m done!");
            Console.ReadLine();
        }

    }
}
