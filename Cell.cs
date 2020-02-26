using System;
using System.Collections.Generic;
using System.Text;


namespace SimpleNavalBattle
{
    public class Cell
    {
        public Ship ShipType { get; set; }

        public Cell()
        {
        }

        public Cell(Ship ship)
        {
            ShipType = ship;
        }

        public bool IsEmpty()
        {
            return ShipType == null;
        }
    }
}