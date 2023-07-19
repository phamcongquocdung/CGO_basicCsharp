using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTNN_trong_mang___phuong_thuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int []array = { 4, 6, 8, 9, 9 };
            int index = MinValue(array);
            Console.WriteLine("Giá Trị Nhỏ Nhất Trong Mảng Là: " + array[index]);

            Console.ReadKey();
        }


        public static int MinValue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
