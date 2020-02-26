using System;
using System.Collections.Generic;
using System.Linq;


namespace SimpleNavalBattle
{
    public class Game
    {
             
        public Player InitPlayer()
        {
                        
            Player player = new Player();
            Console.Write($"Enter name for player: ");
            string name = Console.ReadLine();
            player.Name = name;
            return player;
        }
        public void Start()
        {
            Game first = new Game();
            Player one = first.InitPlayer();
            Console.WriteLine();
            int size = 12;
            Field firstPlayer = new Field(size);
            firstPlayer.GenerateField();
            firstPlayer.ShipPlacement1();
            firstPlayer.ShipPlacement2();
            firstPlayer.ShipPlacement3();
            firstPlayer.ShipPlacement4();
            firstPlayer.MapSelection();
            one.Turn();
            Game second = new Game();
            Player two=second.InitPlayer();
            Console.WriteLine();
            Field secondPlayer = new Field(size);
            secondPlayer.GenerateField();
            secondPlayer.ShipPlacement1();
            secondPlayer.ShipPlacement2();
            secondPlayer.ShipPlacement3();
            secondPlayer.ShipPlacement4();
            secondPlayer.MapSelection();
            two.Turn();
           
            

        }

       
    }
}
