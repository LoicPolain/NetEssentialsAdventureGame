using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameLibrary
{
    internal class Speler
    {
        private string name;
        private Inventory playerInventory;

        public Speler(string name, Inventory playerInventory)
        {
            this.name = name;
            this.playerInventory = playerInventory;
        }

        public Speler(string name)
        {
            this.name = name;
            this.playerInventory = new Inventory();
        }
    }
}
