using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Entity
    {
        public string Name { get; set; }
        public Money Money { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(string name, int cHP, int mHP, int cMP, int mMP, Money money, int exp, int lvl) 
            : base(cHP, mHP, cMP, mMP)
        {
            this.Name = name;
            this.Money = money;
            this.ExperiencePoints = exp;
            this.Level = lvl;

            this.Inventory = new List<InventoryItem>();
            this.Quests = new List<PlayerQuest>();
        }

        public void SetMoney (Money newMoney)
        {
            this.Money = new Money(Money.HexCoins + newMoney.HexCoins, 
                Money.Silver + newMoney.Silver, 
                Money.Scrap + newMoney.Scrap);
        }
    }
}
