using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Quest QuestAvailable { get; set; }
        public Item ItemRequired { get; set; }
        public Monster MonsterLivingHere { get; set; }

        public Location(int id, string name, string description,
            Item itemRequired = null, Quest questAvailabe = null,
            Monster monsterLivingHere = null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.ItemRequired = itemRequired;
            this.QuestAvailable = questAvailabe;
            this.MonsterLivingHere = monsterLivingHere;
        }
    }
}
