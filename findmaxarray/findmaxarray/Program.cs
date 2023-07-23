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
            int m = int.Parse(ReadLine());
            int x = 0, y= 0,k = 0;
            int[,] A = new int[100,100];
            for(int i=1;i<=n;i++)
                for(int j=1;j<=m;j++)
                {
                    A[i, j] = int.Parse(ReadLine());
                }
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    if (A[i, j] > k)
                        k = A[i, j];
                    x = i;
                    y = j;
                }
            WriteLine("toa do: " + x + "," + y);
            WriteLine("gia tri lon nhat: " + k);
            ReadLine();
        }
    }
}
