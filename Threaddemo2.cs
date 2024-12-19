using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Here the simply code of tasks
namespace oopsProject1
{
    class Threaddemo2
    {
        static void method1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("METHOD OF 1 OUTPUT NUMBER" + i);
                Thread.Sleep(500);
            }
        }
        static void method2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("METHOD 0F 2 OUTPUT NUMBER" + i);
                Thread.Sleep(500);
            }
        }

        static  int method3(int a)
        {
            int rem,rev=0;

            while (a != 0)
            {
                rem = a % 10;
                rev = 10 * rev + rem;
                a /= 10;
;
            }
            Console.WriteLine("Output of method 3 =" + rev);
            Thread.Sleep(500);
            
            return rev;
        }

         static void Main(string[] args)
        {
            Thread task = new Thread(method1);
            task.Start();
            Console.WriteLine("Main thread is doing other work...");
            Thread.Sleep(2000); 
            Console.WriteLine("Main thread ends.");
            Thread task2 = new Thread(method2);
            task2.Start(); Console.WriteLine(" Method2 Main thread is doing other work....");
            Console.WriteLine(" Method2 Main threas end ");
            Task<int> t1 = new Task<int>(() => method3(500));
            //task3.method3();


        }



    }
}
