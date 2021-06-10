using System;
using System.Collections.Generic;
using System.Text;

namespace Solak_Project
{
    public class Drop
    {
        public float DropValue { get; set; } // Value of Drop
        

        public float DropAmount { get; set; }  // Amount of Drop

        public int ValueModifier { get; private set; } // The current value of 1x The item

        public string Name { get; set; } //Name of Drop

        public Drop(string name , int valMod)
        {
            Name = name;
            DropValue = 0;
            DropAmount = 0;
            ValueModifier = valMod;
        }

        public void CalculateValue()
        {
            DropValue = (DropAmount * ValueModifier) / 1000000;

        }
    }
}
