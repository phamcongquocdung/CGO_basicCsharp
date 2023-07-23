using System;

class MineSweeper
{
    static void Main(string[] args)
    {
        // Định nghĩa bảng trò chơi
        string[,] map =
        {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };

        int MAP_HEIGHT = map.GetLength(0);
        int MAP_WIDTH = map.GetLength(1);

        string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];

        // Tạo báo cáo với các số mìn xung quanh ô
        for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
        {
            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                if (map[yOrdinate, xOrdinate].Equals("*"))
                {
                    mapReport[yOrdinate, xOrdinate] = "*";
                }
                else
                {
                    int[,] NEIGHBOURS_ORDINATE =
                    {
                        {yOrdinate - 1, xOrdinate - 1}, {yOrdinate - 1, xOrdinate}, {yOrdinate - 1, xOrdinate + 1},
                        {yOrdinate, xOrdinate - 1}, {yOrdinate, xOrdinate + 1},
                        {yOrdinate + 1, xOrdinate - 1}, {yOrdinate + 1, xOrdinate}, {yOrdinate + 1, xOrdinate + 1}
                    };

                    int minesAround = 0;
                    for (int i = 0; i < NEIGHBOURS_ORDINATE.GetLength(0); i++)
                    {
                        int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];
                        int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];

                        bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0 || xOrdinateOfNeighbour >= MAP_WIDTH
                            || yOrdinateOfNeighbour < 0 || yOrdinateOfNeighbour >= MAP_HEIGHT;
                        if (isOutOfMapNeighbour) continue;

                        bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                        if (isMineOwnerNeighbour) minesAround++;
                    }

                    mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
                }
            }
        }

        // Hiển thị báo cáo bảng đếm mìn xung quanh mỗi ô
        for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
        {
            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                string currentCellReport = mapReport[yOrdinate, xOrdinate];
                Console.Write(currentCellReport);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
