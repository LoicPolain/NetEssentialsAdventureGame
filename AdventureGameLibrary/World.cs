using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameLibrary
{
    internal class World
    {
        private readonly List<Room> world;

        public World(List<Room> world)
        {
            this.world = world;
        }
    }
}
