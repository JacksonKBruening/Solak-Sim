using System;
using System.Collections.Generic;
using System.Text;

namespace Solak_Project
{
    public class Unique : Drop
    {
        public int Personal { get; set; } //Stores the number of personals

        public Unique(string name, int valMod) : base(name, valMod)
        {
            Personal = 0;
        }

    }
}
