using System;

namespace SimpleNavalBattle
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string player1 = Console.ReadLine();
            int mapSize = 12;
            int[,] map1 = new int[mapSize, mapSize];
            int[,] map2 = new int[mapSize, mapSize];
            int[,] map3 = new int[mapSize, mapSize];
            int[,] map4 = new int[mapSize, mapSize];
            Console.WriteLine("map1");
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
            Console.WriteLine();
            Console.WriteLine("map2");
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map2[i, k] = i;
                    if (k != 0 && i == 0)
                        map2[i, k] = k;
                    if (i == 4 && k == 4 || i == 9 && k == 2 || i == 5 && k == 7 || i == 5 && k == 10)
                        map2[i, k] = 1;
                    if (i >= 4 && i <= 5 && k == 1 || i == 2 && k >= 2 && k <= 3 || k == 10 && i >= 8 && i <= 9)
                        map2[i, k] = 1;
                    if (k == 8 && i >= 1 && i <= 3 || i == 9 && k >= 5 && k <= 8 || i == 7 && k >= 3 && k <= 5)
                        map2[i, k] = 1;

                    Console.Write($"\t|{map2[i, k]}");
                }

            }
            Console.WriteLine();
            Console.WriteLine("map3");
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map3[i, k] = i;
                    if (k != 0 && i == 0)
                        map3[i, k] = k;
                    if (i == 9 && k == 1 || i == 9 && k == 3 || i == 9 && k == 6 || i == 9 && k == 9)
                        map3[i, k] = 1;
                    if (i >= 2 && i <= 3 && k == 7 || i == 1 && k >= 2 && k <= 3 || k == 10 && i >= 1 && i <= 2)
                        map3[i, k] = 1;
                    if (k == 2 && i >= 3 && i <= 6 || i == 6 && k >= 6 && k <= 8 || k == 10 && i >= 5 && i <= 7)
                        map3[i, k] = 1;

                    Console.Write($"\t|{map3[i, k]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("map4");
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map4[i, k] = i;
                    if (k != 0 && i == 0)
                        map4[i, k] = k;
                    if (i == 1 && k == 2 || i == 3 && k == 4 || i == 5 && k == 6 || i == 7 && k == 8)
                        map4[i, k] = 1;
                    if (i >= 1 && i <= 2 && k == 8 || i >= 4 && i <= 5 && k == 9 || i >= 7 && i <= 8 && k == 10)
                        map4[i, k] = 1;
                    if (i >= 7 && i <= 10 && k == 3 || i == 5 && k >= 1 && k <= 3 || i == 9 && k >= 6 && k <= 8)
                        map4[i, k] = 1;

                    Console.Write($"\t|{map4[i, k]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Choose number of your map:");
            string mapNum1 = Console.ReadLine();
            Console.WriteLine("Press 0 to change player.");
            char nextPlayer = Convert.ToChar(Console.ReadLine());
            if (nextPlayer == '0')
                Console.Clear();
            Console.WriteLine("Enter your name:");
            string player2 = Console.ReadLine();
            Console.WriteLine("map1");
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
            Console.WriteLine();
            Console.WriteLine("map2");
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map2[i, k] = i;
                    if (k != 0 && i == 0)
                        map2[i, k] = k;
                    if (i == 4 && k == 4 || i == 9 && k == 2 || i == 5 && k == 7 || i == 5 && k == 10)
                        map2[i, k] = 1;
                    if (i >= 4 && i <= 5 && k == 1 || i == 2 && k >= 2 && k <= 3 || k == 10 && i >= 8 && i <= 9)
                        map2[i, k] = 1;
                    if (k == 8 && i >= 1 && i <= 3 || i == 9 && k >= 5 && k <= 8 || i == 7 && k >= 3 && k <= 5)
                        map2[i, k] = 1;

                    Console.Write($"\t|{map2[i, k]}");
                }

            }
            Console.WriteLine();
            Console.WriteLine("map3");
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map3[i, k] = i;
                    if (k != 0 && i == 0)
                        map3[i, k] = k;
                    if (i == 9 && k == 1 || i == 9 && k == 3 || i == 9 && k == 6 || i == 9 && k == 9)
                        map3[i, k] = 1;
                    if (i >= 2 && i <= 3 && k == 7 || i == 1 && k >= 2 && k <= 3 || k == 10 && i >= 1 && i <= 2)
                        map3[i, k] = 1;
                    if (k == 2 && i >= 3 && i <= 6 || i == 6 && k >= 6 && k <= 8 || k == 10 && i >= 5 && i <= 7)
                        map3[i, k] = 1;

                    Console.Write($"\t|{map3[i, k]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("map4");
            for (int i = 0; i < mapSize - 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        map4[i, k] = i;
                    if (k != 0 && i == 0)
                        map4[i, k] = k;
                    if (i == 1 && k == 2 || i == 3 && k == 4 || i == 5 && k == 6 || i == 7 && k == 8)
                        map4[i, k] = 1;
                    if (i >= 1 && i <= 2 && k == 8 || i >= 4 && i <= 5 && k == 9 || i >= 7 && i <= 8 && k == 10)
                        map4[i, k] = 1;
                    if (i >= 7 && i <= 10 && k == 3 || i == 5 && k >= 1 && k <= 3 || i == 9 && k >= 6 && k <= 8)
                        map4[i, k] = 1;

                    Console.Write($"\t|{map4[i, k]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Choose number of your map:");
            string mapNum2 = Console.ReadLine();
            Console.WriteLine("Press 0 to change player.");
            if (nextPlayer == '0')
                Console.Clear();
            int[,] myMap1 = new int[mapSize, mapSize];
            switch (mapNum1)
            {
                case "1":
                    {
                        myMap1 = map1;
                        break;
                    }
                case "2":
                    {
                        myMap1 = map2;
                        break;
                    }
                case "3":
                    {
                        myMap1 = map3;
                        break;
                    }
                case "4":
                    {
                        myMap1 = map4;
                        break;
                    }
            }
            int[,] player1Enemy = new int[mapSize, mapSize];
            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        player1Enemy[i, k] = i;
                    else if (k != 0 && i == 0)
                        player1Enemy[i,k] = k;
                    else
                        player1Enemy[i, k] = 0;
                }
            }
            int[,] myMap2 = new int[mapSize, mapSize];
            switch (mapNum2)
            {
                case "1":
                    {
                        myMap2 = map1;
                        break;
                    }
                case "2":
                    {
                        myMap2 = map2;
                        break;
                    }
                case "3":
                    {
                        myMap2 = map3;
                        break;
                    }
                case "4":
                    {
                        myMap2 = map4;
                        break;
                    }
            }
            Console.WriteLine();
            int[,] player2Enemy = new int[mapSize, mapSize];
            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int k = 0; k < mapSize - 1; k++)
                {

                    if (k == 0 && i != 0)
                        player2Enemy[i, k] = i;
                    else if (k != 0 && i == 0)
                        player2Enemy[i, k] = k;
                    else
                        player2Enemy[i, k] = 0;

                }
            }
            int count;
            do
            {
                count = 0;
                Console.WriteLine("My map");
                for (int i = 0; i < mapSize - 1; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < mapSize - 1; k++)
                    {
                        Console.Write($"\t{myMap1[i, k]}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Enemy Map");
                for (int i = 0; i < mapSize - 1; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < mapSize - 1; k++)
                    {
                        Console.Write($"\t{player1Enemy[i, k]}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Enter coordinates for shooting:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Shot1(a, b);
                Console.WriteLine();
                Console.WriteLine("Press 0 to change player.");
                nextPlayer = Convert.ToChar(Console.ReadLine());
                if (nextPlayer == '0')
                    Console.Clear();
                Console.WriteLine("My map");
                for (int i = 0; i < mapSize - 1; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < mapSize - 1; k++)
                    {
                        Console.Write($"\t{myMap2[i, k]}");
                        if (myMap2[i, k] == 1)
                            count++;
                    }
                }
                if(count==0)
                {
                    Console.WriteLine("Player number 1 is winner!");
                    break;
                }
                count = 0;
                Console.WriteLine();
                Console.WriteLine("Enemy Map");
                for (int i = 0; i < mapSize - 1; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < mapSize - 1; k++)
                    {
                        Console.Write($"\t{player2Enemy[i, k]}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Enter coordinates for shooting:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Shot2(a, b);
                for (int i = 0; i < mapSize - 1; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < mapSize - 1; k++)
                    {
                        if (myMap1[i, k] == 1)
                            count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Player number 2 is winner!");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Press 0 to change player.");
                nextPlayer = Convert.ToChar(Console.ReadLine());
                if (nextPlayer == '0')
                    Console.Clear();
            }
            while (count != 0);
            void Shot1(int a, int b)
            {

                if (myMap2[a, b] == 0)
                {
                    myMap2[a, b] = -1;
                    player1Enemy[a, b] = -1;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {

                            Console.Write($"\t|{myMap1[i, k]}");

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {
                            Console.Write($"\t|{player1Enemy[i, k]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ooops! Slip-up.");    
                }
                else if (myMap2[a, b] == 1)
                {
                    myMap2[a, b] = 2;
                    player1Enemy[a, b] = 2;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {

                            Console.Write($"\t|{myMap1[i, k]}");

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {
                            Console.Write($"\t|{player1Enemy[i, k]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Good shot!");
                    Console.WriteLine("Enter coordinates for shooting:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Shot1(a, b);   
                }
                else
                {
                    Console.WriteLine("You've already shooted here, try again.");
                    Console.WriteLine("Enter coordinates for shooting:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Shot1(a, b);
                }
                
            }
            void Shot2(int a, int b)
            {
                if (myMap1[a, b] == 0)
                {
                    myMap1[a, b] = -1;
                    player2Enemy[a, b] = -1;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {

                            Console.Write($"\t|{myMap2[i, k]}");

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {
                            Console.Write($"\t|{player2Enemy[i, k]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ooops! Slip-up.");
                }
                else if (myMap1[a, b] == 1)
                {
                    myMap1[a, b] = 2;
                    player2Enemy[a, b] = 2;
                    Console.Clear();
                    Console.WriteLine("My Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {

                            Console.Write($"\t|{myMap2[i, k]}");

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enemy Map");
                    for (int i = 0; i < mapSize - 1; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < mapSize - 1; k++)
                        {
                            Console.Write($"\t|{player2Enemy[i, k]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Good shot!");
                    Console.WriteLine("Enter coordinates for shooting:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Shot2(a, b);
                }
                else
                {
                    Console.WriteLine("You've already shooted here, try again.");
                    Console.WriteLine("Enter coordinates for shooting:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Shot2(a, b);
                }
                
            }
        }
        
    }
}
