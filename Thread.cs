
namespace oopsProject1
{
    internal class Thread1
    {
        static void print1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print1 Method: {i}");

            }
        }

        static void print2() 
        {
            for(int i = 1;i < 10; i++)
            {
                Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}; Print2 Method: {i}");
            }
        }

        public static void Main (string[] args)
        {
         print1 ();
            print2 ();
        }
    }
}
