using System;
using System.Collections.Generic;

namespace AdventureGameLibrary
{
    public class Room
    {
        private int id;
        private string name;
        private List<Item> loot;

        public Room(int id, string name, List<Item> loot)
        {
            this.id = id;
            this.name = name;
            this.loot = loot;
        }
    }
}
