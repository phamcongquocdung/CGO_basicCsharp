using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_TinhTongPTMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang = new int[5];
            mang[0] = 2;
            mang[1] = 5;
            mang[2] = 9;
            mang[3] = 6;
            mang[4] = 7;

            Console.WriteLine(mang[0]);
            Console.WriteLine(mang[1]);
            Console.WriteLine(mang[2]);

            int tong = 0;
            for (int i=0;i<mang.Length; i++)
            {
                tong = tong + mang[i];
            }
            Console.WriteLine("tong cac phan tu trong mang: " + tong);

            Console.ReadKey();
        }
    }
}
