using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNavalBattle
{
    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public void Turn()
        {
            Console.WriteLine("Press 0 to change player.");
            char nextPlayer = Convert.ToChar(Console.ReadLine());
            if (nextPlayer == '0')
                Console.Clear();
        }
    }
}
