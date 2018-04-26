using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        public Item(int id, string name, string nameplural)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = nameplural;
        }
    }

    public class InventoryItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(Item details, int quantity)
        {
            this.Details = details;
            this.Quantity = quantity;
        }
    }
}
