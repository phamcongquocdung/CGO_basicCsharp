using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi05_DemSoLanXuatHienKiTu
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string chuoi = "major depressive disorder";
            Console.Write("Nhập một kí tự: ");
            char KiTu = Console.ReadLine()[0];

            int dem = 0;

            for(int i=0;i<chuoi.Length; i++)
            {
                if(chuoi[i] == KiTu)
                {
                    dem++;
                }
            }
            Console.WriteLine("Số lần xuất hiện của kí tự trong '{0}' chuỗi là : {1}", KiTu, dem);

            Console.ReadKey();
        }
        
    }
}
