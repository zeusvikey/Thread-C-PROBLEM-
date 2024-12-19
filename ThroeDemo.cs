using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsProject1
{
    internal class ThroeDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int b = int.Parse(Console.ReadLine());


                if (b % 2 >= 0)
                {
                    throw new ApplicationException();
                }
                int c = a / b;

                Console.WriteLine("ANSWEr" + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);



            }
        }
    }
}
