using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RewardGold { get; set; }
        public int RewardExperiencePoints { get; set; }
        public Item RewardItem { get; set; }

        public List<QuestCompletionItem> QuestItemsToComplete { get; set; }

        public Quest(int id, string title, string desc, int rGold, int rExp)
        {
            this.ID = id;
            this.Title = title;
            this.Description = desc;
            this.RewardGold = rGold;
            this.RewardExperiencePoints = rExp;

            this.QuestItemsToComplete = new List<QuestCompletionItem>();
        }
    }

    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuest(Quest details)
        {
            this.Details = details;
            this.IsCompleted = false;
        }
    }

    public class QuestCompletionItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public QuestCompletionItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
