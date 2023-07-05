
using System.Text;

namespace CGO_Buoi01
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            Console.WriteLine("Mời bạn nhập tên: ");
            string sHoTen = Console.ReadLine();
            Console.WriteLine("Tên bạn là " + sHoTen);
            Console.ReadKey();
           
        }
    }
}