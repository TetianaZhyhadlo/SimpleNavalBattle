using System;
using System.Xml.Linq;


namespace SimpleNavalBattle
{

    public class Field
    {
        public int FieldSize { get; }
        public Cell[,] Cells { get; }


        public Field(int field)
        {
            Cells = new Cell[field, field];
            FieldSize = field;
        }

        public void GenerateField()
        {
            for (int i = 0; i < FieldSize - 1; i++)
            {
                for (int k = 0; k < FieldSize - 1; k++)
                {
                    Cells[i, k] = new Cell();

                }
            }
        }

        public void ShowField()
        {
            for (int i = 0; i < FieldSize - 1; i++)
            {
                for (int k = 0; k < FieldSize - 1; k++)
                {
                    Extensions.ToConsoleWrite("|", ConsoleColor.DarkBlue);
                    if (k == 0 && i != 0)
                        Extensions.ToConsoleWrite($"{i}", ConsoleColor.White);
                    else if (i == 0 && k != 0)
                        Extensions.ToConsoleWrite($"{k}", ConsoleColor.White);
                    else if (Cells[i, k].ShipType != null && Cells[i, k].ShipType.ShipAlive)
                        Extensions.ToConsoleWrite("▲", ConsoleColor.Green);
                    else if (Cells[i, k].ShipType != null && !Cells[i, k].ShipType.ShipAlive)
                        Extensions.ToConsoleWrite("▼", ConsoleColor.Red);
                    else if (Cells[i, k].ShipType != null && Cells[i, k].ShipType.IsEmpty)
                        Extensions.ToConsoleWrite("○", ConsoleColor.Red);
                    else
                        Extensions.ToConsoleWrite(" ");
                }
                Extensions.ToConsole("|", ConsoleColor.DarkBlue);
            }
        }
        int mapNum1;
        public void ShipPlacement1()
        {
            mapNum1 = 1;
            Console.WriteLine($"Map {mapNum1}");
            for (int i = 0; i < 11; i++)
            {
                for (int k = 0; k < 11; k++)
                {
                    Extensions.ToConsoleWrite("\t|", ConsoleColor.DarkBlue);
                    if (k == 0 && i != 0)
                        Extensions.ToConsoleWrite($"{i}", ConsoleColor.White);
                    else if (i == 0 && k != 0)
                        Extensions.ToConsoleWrite($"{k}", ConsoleColor.White);
                    else if (i == 1 && k == 1 || i == 3 && k == 8 || i == 7 && k == 4 || i == 10 && k == 8 ||
                        i == 1 && k >= 9 && k <= 10 || i >= 1 && i <= 2 && k == 5 || i == 10 && k >= 4 && k <= 5 ||
                        k == 1 && i >= 8 && i <= 10 || i == 4 && k >= 2 && k <= 5 || k == 10 && i >= 5 && i <= 7)
                        Extensions.ToConsoleWrite("▲", ConsoleColor.Green);
                    else
                        Extensions.ToConsoleWrite(" ");
                }
                Extensions.ToConsole("\t|", ConsoleColor.DarkBlue);
            }
        }
        int mapNum2;
        public void ShipPlacement2()
        {
            mapNum2 = 2;
            Console.WriteLine($"Map {mapNum2}");
            for (int i = 0; i < 11; i++)
            {
                for (int k = 0; k < 11; k++)
                {
                    Extensions.ToConsoleWrite("\t|", ConsoleColor.DarkBlue);
                    if (k == 0 && i != 0)
                        Extensions.ToConsoleWrite($"{i}", ConsoleColor.White);
                    else if (i == 0 && k != 0)
                        Extensions.ToConsoleWrite($"{k}", ConsoleColor.White);
                    else if (i == 4 && k == 4 || i == 9 && k == 2 || i == 5 && k == 7 || i == 5 && k == 10 ||
                        i >= 4 && i <= 5 && k == 1 || i == 2 && k >= 2 && k <= 3 || k == 10 && i >= 8 && i <= 9 ||
                        k == 8 && i >= 1 && i <= 3 || i == 9 && k >= 5 && k <= 8 || i == 7 && k >= 3 && k <= 5)
                        Extensions.ToConsoleWrite("▲", ConsoleColor.Green);
                    else
                        Extensions.ToConsoleWrite(" ");
                }
                Extensions.ToConsole("\t|", ConsoleColor.DarkBlue);
            }
        }
        int mapNum3;
        public void ShipPlacement3()
        {
            mapNum3 = 3;
            Console.WriteLine($"Map {mapNum3}");
            for (int i = 0; i < 11; i++)
            {
                for (int k = 0; k < 11; k++)
                {
                    Extensions.ToConsoleWrite("\t|", ConsoleColor.DarkBlue);
                    if (k == 0 && i != 0)
                        Extensions.ToConsoleWrite($"{i}", ConsoleColor.White);
                    else if (i == 0 && k != 0)
                        Extensions.ToConsoleWrite($"{k}", ConsoleColor.White);
                    else if (i == 9 && k == 1 || i == 9 && k == 3 || i == 9 && k == 6 || i == 9 && k == 9 ||
                        i >= 2 && i <= 3 && k == 7 || i == 1 && k >= 2 && k <= 3 || k == 10 && i >= 1 && i <= 2 ||
                        k == 2 && i >= 3 && i <= 6 || i == 6 && k >= 6 && k <= 8 || k == 10 && i >= 5 && i <= 7)
                        Extensions.ToConsoleWrite("▲", ConsoleColor.Green);
                    else
                        Extensions.ToConsoleWrite(" ");
                }
                Extensions.ToConsole("\t|", ConsoleColor.DarkBlue);
            }
        }
        int mapNum4;
        public void ShipPlacement4()
        {
            mapNum4 = 4;
            Console.WriteLine($"Map {mapNum4}");
            for (int i = 0; i < 11; i++)
            {
                for (int k = 0; k < 11; k++)
                {
                    Extensions.ToConsoleWrite("\t|", ConsoleColor.DarkBlue);
                    if (k == 0 && i != 0)
                        Extensions.ToConsoleWrite($"{i}", ConsoleColor.White);
                    else if (i == 0 && k != 0)
                        Extensions.ToConsoleWrite($"{k}", ConsoleColor.White);
                    else if (i == 1 && k == 2 || i == 3 && k == 4 || i == 5 && k == 6 || i == 7 && k == 8 ||
                        i >= 1 && i <= 2 && k == 8 || i >= 4 && i <= 5 && k == 9 || i >= 7 && i <= 8 && k == 10 ||
                        i >= 7 && i <= 10 && k == 3 || i == 5 && k >= 1 && k <= 3 || i == 9 && k >= 6 && k <= 8)
                        Extensions.ToConsoleWrite("▲", ConsoleColor.Green);
                    else
                        Extensions.ToConsoleWrite(" ");
                }
                Extensions.ToConsole("\t|", ConsoleColor.DarkBlue);
            }
        }
        public void MapSelection()
        {
            Console.WriteLine("Choose number of your map:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num < 5)
            {
                if (num == mapNum1)
                {
                    Console.Clear();
                    ShipPlacement1();
                    Console.WriteLine();

                    
                }
                else if (num == mapNum2)
                {
                    Console.Clear();
                    ShipPlacement2();
                    Console.WriteLine();

                    
                }
                else if (num == mapNum3)
                {
                    Console.Clear();
                    ShipPlacement3();
                    Console.WriteLine();
                    
                }
                else if (num == mapNum4)
                {
                    Console.Clear();
                    ShipPlacement4();
                    Console.WriteLine();
                   
                }
            }
            else
            {
                MapSelection();
            }
        }
        public bool Winner(Ship ship)
        {
            for (int i = 0; i < FieldSize-1; i++)
            {
                for (int k = 0; k < FieldSize-1; k++)
                {
                    if (Cells[i, k].ShipType.ShipAlive)
                        return false;
                }
            }
            return true;
        }
        public void Shooting(int a, int b)
        {

        }
    }
}