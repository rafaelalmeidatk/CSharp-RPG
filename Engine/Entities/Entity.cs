using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Entity
    {
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
        public int CurrentManaPoints { get; set; }
        public int MaximumManaPoints { get; set; }

        public Entity(int cHP, int mHP, int cMP, int mMP)
        {
            this.CurrentHitPoints = cHP;
            this.MaximumHitPoints = mHP;
            this.CurrentManaPoints = cMP;
            this.MaximumManaPoints = mMP;
        }
    }
}
