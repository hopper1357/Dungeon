using System.Collections.Generic;
using System.Linq;

namespace Dungeon.Models
{
    public class Stockpile
    {
        public List<Item> Items { get; private set; }

        public Stockpile()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            var existingItem = Items.FirstOrDefault(i => i.Name == item.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }

        public bool RemoveItem(string itemName, int quantity)
        {
            var existingItem = Items.FirstOrDefault(i => i.Name == itemName);
            if (existingItem != null)
            {
                if (existingItem.Quantity >= quantity)
                {
                    existingItem.Quantity -= quantity;
                    if (existingItem.Quantity == 0)
                    {
                        Items.Remove(existingItem);
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
