using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_TimGTLNMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int size = 0;
            int[] array;
            while (size <= 20)
            {
                Console.WriteLine("Nhập kích thước:");
                size = int.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Kích thước khôhng được vượt quá 20");
                    break;
                }
                array = new int[size];
                int i = 0;
                while (i < array.Length)
                {
                    Console.WriteLine("Nhập phần tử " + (i + 1) + " là: ");
                    array[i] = int.Parse(Console.ReadLine());
                    i++;
                }

                Console.WriteLine("Danh sách phần tử");
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[j] + "\t");
                }

                int max = array[0];
                int index = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        max = array[j];
                        index = j + 1;
                    }
                }
                Console.WriteLine("Giá Trị Lớn Nhất Trong Danh Sách là " + max + ", ở vị trí thứ " + index);
            }

            Console.ReadKey();
        }
    }
}
