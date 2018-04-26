using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string nameplural, int minDmg, int maxDmg) 
            : base(id, name, nameplural)
        {
            this.MinimumDamage = minDmg;
            this.MaximumDamage = maxDmg;
        }
    }
}
