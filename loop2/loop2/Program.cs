using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(ReadLine());
            if (number < 2)
                Write("khong phai so nguyen to");
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    WriteLine(number + " la so nguyen to");
                }
                else
                {
                    WriteLine(number + " khong la so nguyen ");
                }
            }

        }
    }
}
