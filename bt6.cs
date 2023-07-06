using System;
using System.Text;

namespace CGO_Buoi02_ChiSoCanNang
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double height;
            double weight;

            Console.WriteLine("Hãy nhập chiều cao");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Hãy Nhập cân nặng");
            weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine(" Suy dinh dưỡng ");
            else if (bmi < 25.0)
                Console.WriteLine(" Trung Bình ");
            else if (bmi < 30.0)
                Console.WriteLine(" Thừa cân ");
            else
                Console.WriteLine(" Béo Phì ");
        }
    }
}