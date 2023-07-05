
using System;
using System.Text;

namespace CGO_Buoi01
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            const int tigia = 23000;
            Console.Write("Mời bạn nhập số USD: ");
            string input = Console.ReadLine();  

            int dola = int.Parse(input);
            Console.WriteLine("số tiền VND của bạn là " + dola*tigia);
            Console.ReadKey();

        }
    }
}