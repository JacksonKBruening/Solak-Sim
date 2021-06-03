using System;
using System.Collections.Generic;
using System.Text;

namespace Dwarfs_Project
{
    public class Drop
    {
        public int DropType { get; set; } // For now I made this an int type, but I reccomend looking into enum types later on and implementing this as an enum type

        public int Rarity { get; set; }  // again make this into an enum type in the future

        public string Name { get; set; } // These get; set are shortcuts for getting/setting values, so you don't have to make a fancy function just to get/set these variables.


        public int GetDropCount()
        {
            return 0;
        }
    }
}
