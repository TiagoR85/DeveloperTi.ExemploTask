using System;
using System.Threading;
using System.Threading.Tasks;

namespace DeveloperTi.ExemploTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";
            Task taskA = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Hello from taskA.");
            });
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
            Thread.Sleep(4000);
            taskA.Wait();//aguardável da thread.
        }
    }
}
