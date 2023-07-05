using System;
using System.Text;

namespace SystemTime
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("Có nghiệm là: {0}!", solution);
            }

            else
            {
                if (b == 0)
                {
                    Console.Write("Phương trình có vô số nghiệm");
                }
                else
                {
                    Console.Write("Phương trình vô nghiệm!");
                }
            }

        }
    }
}