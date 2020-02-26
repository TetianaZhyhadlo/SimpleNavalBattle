using System;

namespace SimpleNavalBattle
{
    class Program
    {

        static void Main(string[] args)
        {
            Game a = new Game();
            a.Start();
        



           
            //int[,] myMap1 = new int[mapSize, mapSize];
            //switch (mapNum1)
            //{
            //    case "1":
            //        {
            //            myMap1 = map1;
            //            break;
            //        }
            //    case "2":
            //        {
            //            myMap1 = map2;
            //            break;
            //        }
            //    case "3":
            //        {
            //            myMap1 = map3;
            //            break;
            //        }
            //    case "4":
            //        {
            //            myMap1 = map4;
            //            break;
            //        }
            //}
            //int[,] player1Enemy = new int[mapSize, mapSize];
            //for (int i = 0; i < mapSize - 1; i++)
            //{
            //    for (int k = 0; k < mapSize - 1; k++)
            //    {

            //        if (k == 0 && i != 0)
            //            player1Enemy[i, k] = i;
            //        else if (k != 0 && i == 0)
            //            player1Enemy[i,k] = k;
            //        else
            //            player1Enemy[i, k] = 0;
            //    }
            //}
            //int[,] myMap2 = new int[mapSize, mapSize];
            //switch (mapNum2)
            //{
            //    case "1":
            //        {
            //            myMap2 = map1;
            //            break;
            //        }
            //    case "2":
            //        {
            //            myMap2 = map2;
            //            break;
            //        }
            //    case "3":
            //        {
            //            myMap2 = map3;
            //            break;
            //        }
            //    case "4":
            //        {
            //            myMap2 = map4;
            //            break;
            //        }
            //}
            //Console.WriteLine();
            //int[,] player2Enemy = new int[mapSize, mapSize];
            //for (int i = 0; i < mapSize - 1; i++)
            //{
            //    for (int k = 0; k < mapSize - 1; k++)
            //    {

            //        if (k == 0 && i != 0)
            //            player2Enemy[i, k] = i;
            //        else if (k != 0 && i == 0)
            //            player2Enemy[i, k] = k;
            //        else
            //            player2Enemy[i, k] = 0;

            //    }
            //}
            //int count;
            //do
            //{
            //    count = 0;
            //    Console.WriteLine("My map");
            //    for (int i = 0; i < mapSize - 1; i++)
            //    {
            //        Console.WriteLine();
            //        for (int k = 0; k < mapSize - 1; k++)
            //        {
            //            Console.Write($"\t{myMap1[i, k]}");
            //        }
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Enemy Map");
            //    for (int i = 0; i < mapSize - 1; i++)
            //    {
            //        Console.WriteLine();
            //        for (int k = 0; k < mapSize - 1; k++)
            //        {
            //            Console.Write($"\t{player1Enemy[i, k]}");
            //        }
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Enter coordinates for shooting:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    Shot1(a, b);
            //    Console.WriteLine();
            //    Console.WriteLine("Press 0 to change player.");
            //    nextPlayer = Convert.ToChar(Console.ReadLine());
            //    if (nextPlayer == '0')
            //        Console.Clear();
            //    Console.WriteLine("My map");
            //    for (int i = 0; i < mapSize - 1; i++)
            //    {
            //        Console.WriteLine();
            //        for (int k = 0; k < mapSize - 1; k++)
            //        {
            //            Console.Write($"\t{myMap2[i, k]}");
            //            if (myMap2[i, k] == 1)
            //                count++;
            //        }
            //    }
            //    if(count==0)
            //    {
            //        Console.WriteLine("Player number 1 is winner!");
            //        break;
            //    }
            //    count = 0;
            //    Console.WriteLine();
            //    Console.WriteLine("Enemy Map");
            //    for (int i = 0; i < mapSize - 1; i++)
            //    {
            //        Console.WriteLine();
            //        for (int k = 0; k < mapSize - 1; k++)
            //        {
            //            Console.Write($"\t{player2Enemy[i, k]}");
            //        }
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Enter coordinates for shooting:");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());
            //    Shot2(a, b);
            //    for (int i = 0; i < mapSize - 1; i++)
            //    {
            //        for (int k = 0; k < mapSize - 1; k++)
            //        {
            //            if (myMap1[i, k] == 1)
            //                count++;
            //        }
            //    }
            //    if (count == 0)
            //    {
            //        Console.WriteLine("Player number 2 is winner!");
            //        break;
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Press 0 to change player.");
            //    nextPlayer = Convert.ToChar(Console.ReadLine());
            //    if (nextPlayer == '0')
            //        Console.Clear();
            //}
            //while (count != 0);
            //void Shot1(int a, int b)
            //{

            //    if (myMap2[a, b] == 0)
            //    {
            //        myMap2[a, b] = -1;
            //        player1Enemy[a, b] = -1;
            //        Console.Clear();
            //        Console.WriteLine("My Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {

            //                Console.Write($"\t|{myMap1[i, k]}");

            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Enemy Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {
            //                Console.Write($"\t|{player1Enemy[i, k]}");
            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Ooops! Slip-up.");    
            //    }
            //    else if (myMap2[a, b] == 1)
            //    {
            //        myMap2[a, b] = 2;
            //        player1Enemy[a, b] = 2;
            //        Console.Clear();
            //        Console.WriteLine("My Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {

            //                Console.Write($"\t|{myMap1[i, k]}");

            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Enemy Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {
            //                Console.Write($"\t|{player1Enemy[i, k]}");
            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Good shot!");
            //        Console.WriteLine("Enter coordinates for shooting:");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        b = Convert.ToInt32(Console.ReadLine());
            //        Shot1(a, b);   
            //    }
            //    else
            //    {
            //        Console.WriteLine("You've already shooted here, try again.");
            //        Console.WriteLine("Enter coordinates for shooting:");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        b = Convert.ToInt32(Console.ReadLine());
            //        Shot1(a, b);
            //    }
                
            //}
            //void Shot2(int a, int b)
            //{
            //    if (myMap1[a, b] == 0)
            //    {
            //        myMap1[a, b] = -1;
            //        player2Enemy[a, b] = -1;
            //        Console.Clear();
            //        Console.WriteLine("My Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {

            //                Console.Write($"\t|{myMap2[i, k]}");

            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Enemy Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {
            //                Console.Write($"\t|{player2Enemy[i, k]}");
            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Ooops! Slip-up.");
            //    }
            //    else if (myMap1[a, b] == 1)
            //    {
            //        myMap1[a, b] = 2;
            //        player2Enemy[a, b] = 2;
            //        Console.Clear();
            //        Console.WriteLine("My Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {

            //                Console.Write($"\t|{myMap2[i, k]}");

            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Enemy Map");
            //        for (int i = 0; i < mapSize - 1; i++)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < mapSize - 1; k++)
            //            {
            //                Console.Write($"\t|{player2Enemy[i, k]}");
            //            }
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("Good shot!");
            //        Console.WriteLine("Enter coordinates for shooting:");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        b = Convert.ToInt32(Console.ReadLine());
            //        Shot2(a, b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("You've already shooted here, try again.");
            //        Console.WriteLine("Enter coordinates for shooting:");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        b = Convert.ToInt32(Console.ReadLine());
            //        Shot2(a, b);
            //    }
                
            //}
        }
        
    }
}
