using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace findmaxarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            int sum = 0;
            int[,] A = new int[100, 100];
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <=n ; j++)
                {
                    A[i, j] = int.Parse(ReadLine());
                }
            for (int i = 1; i <= n; i++)
                sum += A[i, i];
            WriteLine(sum);
            ReadLine();
        }
    }
}