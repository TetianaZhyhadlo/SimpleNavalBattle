using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNavalBattle
{
    public class Ship
    {
        public bool ShipAlive { get; set; }
        public int ShipLenght { get; set; }
        public bool IsEmpty { get; set; }
        
        public enum ShipName { battleship, cruiser, destroyer, submarine };
        public ShipName Name { get; set; }

        public Ship(ShipName name)
        {
            int shipLength = 0;
            switch (name)
            {
                case ShipName.submarine:
                    shipLength = 1;
                    break;
                case ShipName.destroyer:
                    shipLength = 2;
                    break;
                case ShipName.cruiser:
                    shipLength = 3;
                    break;
                case ShipName.battleship:
                    shipLength = 4;
                    break;
            }
            this.ShipLenght = shipLength;
            this.Name = name;
        }
        



        

    }
}
