using System;
using System.Text;

namespace CGO_Buoi02_DocSoThanhChu
{
    class Program
    {
        
        static string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "six", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };

        static string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            string words = ConvertNumberToWords(number);
            Console.WriteLine(words);
        }


        static string ConvertNumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + ConvertNumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 100) > 0)
            {
                words += ConvertNumberToWords(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    words += ones[number];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + ones[number % 10];
                }
            }

            return words;
        }
    }
}
