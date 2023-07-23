using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_TimGTMang
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "An", "Mai", "Lan", "Hung" };

            Console.WriteLine("Hay nhap ten tim kiem:");
            string input_name = Console.ReadLine();

            bool isExsist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Vi tri cua sinh vien trong danh sach " + input_name + " la: " + (i + 1));
                    isExsist = true;
                    break;
                }

            }
            if (!isExsist)
            {
                Console.WriteLine("Khong tim thay ten sinh vien!");
            }
            Console.ReadKey();
        }
    }
}
