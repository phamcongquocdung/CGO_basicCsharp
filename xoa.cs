using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_XoaPTMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //int[] array = { 10, 4, 6, 7, 8, 6 };
            Console.WriteLine("Nhập số phần tử trong mảng");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Nhập các pt trong mảng: ");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Phần tử thứ " + (i + 1) + "là: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhập phần tử cần xoá là x");
            int x;
            x = int.Parse(Console.ReadLine());


            int index_del = 0;
            for(int i=0;i<n;i++)
            {
                if(array[i] == x)
                {
                    index_del = i;
                    break;
                }
            }
            if(index_del != 0)
            {
                for (int i=index_del;i<n-1;i++)
                {
                    array[i] = array[i + 1];
                }
                n--;

                Console.WriteLine("Mảng sau khi đã xoá là:");
                for(int i=0;i<n;i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else 
            {
                Console.WriteLine("Không tìm thấy x trong mảng đã cho");
            }
            Console.ReadKey();
        }
    }
}
