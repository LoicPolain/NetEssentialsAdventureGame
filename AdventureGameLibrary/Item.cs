using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameLibrary
{
    public class Item
    {
        private string name;
        private int id;
        private bool takeable;
        private bool useableable;
        private bool lookable;

        public Item(string name, int id, bool takeable, bool useableable, bool lookable)
        {            
            this.name = name;
            this.id = id;
            this.takeable = takeable;
            this.useableable = useableable;
            this.lookable = lookable;
        }
    }
}
