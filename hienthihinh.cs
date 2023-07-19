using System;
using System.Text;

class HienThiCacLoaiHinh
{
    static void PrintMenu()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("Menu: ");
        Console.WriteLine("1.In Hình Chữ Nhật ");
        Console.WriteLine("2.In Hình Các Tam Giác Vuông ");
        Console.WriteLine("3.In Tam Giác Cân");
        Console.WriteLine("4. Thoát Menu");
    }
    static void InHinhChuNhat(int width, int height, char symbol)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

    static void InTamGiacVuong(int size, char symbol, string position)
    {
        switch (position)
        {
            case "top-left":
                for (int i = size; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                break;
            case "top-right":
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= size - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                break;
            case "bottom-left":
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                break;
            case "bottom-right":
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                break;
        }
    }

    static void InTamGiacCan(int height, char symbol)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            PrintMenu();
            Console.Write("Nhập lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập chiều rộng hình chữ nhật: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("Nhập chiều cao hình chữ nhật: ");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("Nhập biểu tượng vẽ mà bạn muốn: ");
                    char rectangleSymbol = Console.ReadLine()[0];
                    InHinhChuNhat(width, height, rectangleSymbol);
                    break;
                case 2:
                    Console.Write("nhập kích thước của tam giác: ");
                    int squareTriangleSize = int.Parse(Console.ReadLine());
                    Console.Write("Nhập biểu tượng vẽ mà bạn muốn: ");
                    char squareTriangleSymbol = Console.ReadLine()[0];
                    Console.Write("Chọn góc vuông của tam giác (top-left, top-right, bottom-left, bottom-right): ");
                    string squareTrianglePosition = Console.ReadLine();
                    InTamGiacVuong(squareTriangleSize, squareTriangleSymbol, squareTrianglePosition);
                    break;
                case 3:
                    Console.Write("Nhập chiều cao tam giác cân: ");
                    int isoscelesTriangleHeight = int.Parse(Console.ReadLine());
                    Console.Write("Nhập biểu tượng vẽ mà bạn muốn: ");
                    char isoscelesTriangleSymbol = Console.ReadLine()[0];
                    InTamGiacCan(isoscelesTriangleHeight, isoscelesTriangleSymbol);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
