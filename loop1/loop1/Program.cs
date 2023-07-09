using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            while (x != 0)
            {
                Console.WriteLine("Menu: \n 1. Hinh Vuong \n 2. Hinh tam giac \n 3. Hinh Thang \n 4. Hinh chu nhat \n 0. Exit");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        for(int i=1;i<=5;i++)
                        {
                            for(int j=1;j<=5;j++)
                                Console.Write("* ");
                            Console.Write("\n");
                        }
                        break;
                    case 2:
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= i; j++)
                                Console.Write("* ");
                            Console.Write("\n");
                        }
                        break;
                    case 4:
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= 3; j++)
                                Console.Write("* ");
                            Console.Write("\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("  * * * * *   ");
                        Console.WriteLine(" * * * * * * ");
                        Console.WriteLine("* * * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;

                }
            }

        }
    }
}
