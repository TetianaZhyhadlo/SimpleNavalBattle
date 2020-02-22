using System;

namespace SimpleNavalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int mapSize=12;
            int[,] map1 = new int[mapSize, mapSize];
            int[,] map2 = new int[mapSize, mapSize];
            int[,] map3 = new int[mapSize, mapSize];
            int[,] map4 = new int[mapSize, mapSize];
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map1[i, k] = i;
                    if (k != 0 && i == 0)
                        map1[i, k] = k;
                    if (i == 1 && k == 1 || i == 3 && k == 8 || i == 7 && k == 4 || i == 10 && k == 8)
                        map1[i, k] = 1;
                    if (i == 1 && k >= 9 && k <= 10 || i >= 1 && i <= 2 && k == 5 || i == 10 && k >= 4 && k <= 5)
                        map1[i, k] = 1;
                    if (k == 1 && i >= 8 && i <= 10 || i == 4 && k >= 2 && k <= 5 || k == 10 && i >= 5 && i <= 7)
                        map1[i, k] = 1;

                    Console.Write($"\t|{map1[i, k]}");
                }
            }
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map2[i, k] = i;
                    if (k != 0 && i == 0)
                        map2[i, k] = k;
                    if (i >=4 && i<=5 && k == 1 || i == 3 && k == 8 || i == 7 && k == 4 || i == 10 && k == 8)
                        map2[i, k] = 1;
                    if (i == 1 && k >= 9 && k <= 10 || i >= 1 && i <= 2 && k == 5 || i == 10 && k >= 4 && k <= 5)
                        map2[i, k] = 1;
                    if (k == 1 && i >= 8 && i <= 10 || i == 4 && k >= 2 && k <= 5 || k == 10 && i >= 5 && i <= 7)
                        map2[i, k] = 1;

                    Console.Write($"\t|{map1[i, k]}");
                }
            }

        }
    }
}
