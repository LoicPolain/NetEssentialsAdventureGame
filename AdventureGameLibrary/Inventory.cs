using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameLibrary
{
    internal class Inventory
    {
        private List<Item> inventory;
        private int maxItems;
        public int MyProperty { get; set; }

        public Inventory(List<Item> inventory, int maxItems)
        {
            this.inventory = inventory;
            this.maxItems = maxItems;
        }

        public Inventory()
        {
            this.inventory = new List<Item>();
            this.maxItems = 10;
        }      
    }
}
