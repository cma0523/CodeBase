using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncEngine
{
    public  class AsyncService
    {
        public async Task AsyncTask()
        {
            Console.WriteLine($"我是方法AsyncTask");
            await InnerWasteTime();
            Console.WriteLine("我已经干完了我应该干的事情ABC!");
        }

        private async Task<string> WasteTime()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1);//避免Console.WriteLine执行太快使整个程序执行起来像是同步执行的
                //InnerWasteTime();
                Console.WriteLine("我开始异步执行了!");
                Console.WriteLine("可是我啥都不想干,还是等个五秒钟就跟主线程说我做好了吧");
                Thread.Sleep(5000);
                return "我异步执行完了";
            });
        }

        private async Task InnerWasteTime()
        {
             await Task.Run(() =>
             {
                 Thread.Sleep(1);//避免Console.WriteLine执行太快使整个程序执行起来像是同步执行的
                                 //InnerWasteTime();
                 Console.WriteLine("我开始异步执行了!");
                 Console.WriteLine("可是我啥都不想干,还是等个五秒钟就跟主线程说我做好了吧");
                 Thread.Sleep(5000);
                 Console.WriteLine("我异步执行完了");
             }
             );
        }
    }
}
