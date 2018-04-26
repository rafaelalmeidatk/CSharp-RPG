using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardGold { get; set; }
        public int RewardExperiencePoints { get; set; }

        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int cHP, int mHP, int cMP, int mMP, int maxDmg, int rGold, int rExp) 
            : base(cHP, mHP, cMP, mMP)
        {
            this.ID = id;
            this.Name = name;
            this.MaximumDamage = maxDmg;
            this.RewardGold = rGold;
            this.RewardExperiencePoints = rExp;

            this.LootTable = new List<LootItem>();
        }
    }

    public class LootItem
    {
        public Item Details { get; set; }
        public int DropChance { get; set; }
        public bool IsDefaultDrop { get; set; }

        public LootItem(Item details, int dropChance, bool isDefault)
        {
            this.Details = details;
            this.DropChance = dropChance;
            this.IsDefaultDrop = isDefault;
        }
    }
}
