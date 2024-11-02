using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andre_Inventory
{
    internal class Order : Item
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public decimal TotalPrice { get; set; }

        public void AddItem(Inventory inventory, string itemName, int quantity)
        {
            var item = inventory.GetItems().Find(i => i.Name == itemName);
            if (item != null)
            {
                Items.Add(item);
                TotalPrice += item.Price * quantity;
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }
         public void ProcessOrder(Inventory inventory)
       {
          foreach (var item in Items)
          {
            inventory.UpdateQuantity(item.Name, item.Quantity - 1);
          }
          Console.WriteLine("====================================");
          Console.WriteLine("Order Processed");
          Console.WriteLine("====================================");
          Console.WriteLine($"Total Price: ${TotalPrice:0.00}");
       }
    }
}
