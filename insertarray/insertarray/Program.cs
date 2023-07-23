using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace insertarray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>();
            int n = int.Parse(ReadLine());
            for (int i = 1; i <= n; i++)
                A.Add(int.Parse(ReadLine()));
            WriteLine("nhap gia tri can chen: ");
            int gt = int.Parse(ReadLine());
            WriteLine("nhap vi tri can chen: ");
            int vt = int.Parse(ReadLine());
            if (vt <= 1 || vt >= n - 1)
                WriteLine("khong chen duoc phan tu vao mang");
            else
            {
                A.Insert(vt, gt);
                for (int i = 0; i <= n - 1; i++)
                    WriteLine(A[i]);
            }
            ReadLine();
        }
    }
}
