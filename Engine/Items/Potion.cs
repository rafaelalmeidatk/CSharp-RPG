using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Potion : Item
    {
        public int AmountToRestore { get; set; }

        public Potion(int id, string name, string nameplural, int power) 
            : base(id, name, nameplural)
        {
            this.AmountToRestore = power;
        }
    }
}
