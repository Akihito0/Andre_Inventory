

namespace Andre_Inventory
{
    class Inventory : Item
{
    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(string name)
    {
        items.RemoveAll(i => i.Name == name);
    }

    public void UpdateQuantity(string name, int newQuantity)
    {
        var item = items.Find(i => i.Name == name);
        if (item != null)
        {
            item.Quantity = newQuantity;
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Inventory");
        Console.WriteLine("====================================");
        foreach (var item in items)
        {
            Console.WriteLine($"Name: {item.Name,-20} Quantity: {item.Quantity,3} Price: ${item.Price:0.00}");
        }
    }

    public List<Item> GetItems()
    {
        return new List<Item>(items);
    }
}

}