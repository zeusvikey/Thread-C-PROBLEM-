using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsProject1
{
    class Threaddemo2
    {
        static void print1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print1 Method: {i}");
            }
        }

        static void print2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print2 Method: {i}");
            }
        }

        static void print3()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print3 Method: {i}");
            }
        }

        static void Main(string[] args)
        {
            Task t1 = new Task(print1);
            Task t2 = new Task(print2);
            Task t3 = new Task(print3);
            Task a = Task.Factory.StartNew(print1);
            Task b = Task.Factory.StartNew(print2);
            Task c = Task.Factory.StartNew(print3);
            Task.WaitAll(t1, t2, t3);
            Console.WriteLine($"Main thread with Id: {Thread.CurrentThread.ManagedThreadId} is exiting.");

        }

    }


}
