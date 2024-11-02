namespace Andre_Inventory
{
    internal class Program
    {

            static void Main(string[] args)
            {
                Inventory inventory = new Inventory();


                List<Item> initialItems = new List<Item>()
            {
                new Item { Name = "Coffee Beans", Quantity = 100, Price = 10.00m },
                new Item { Name = "Milk", Quantity = 50, Price = 2.00m },
                new Item { Name = "Americano Latte", Quantity = 20, Price = 3.00m },
                new Item { Name  = "Cheese Cake", Quantity = 20, Price = 100.00m},
                new Item { Name  = "Tea", Quantity = 50, Price = 50.00m},
                new Item { Name  = "Affogato", Quantity = 50, Price = 50.00m}
            };

                foreach (var item in initialItems)
                {
                    inventory.AddItem(item);
                }

                DisplayTitle("Initial Inventory");
                inventory.DisplayInventory();


                Order order = new Order();
                while (true)
                {
                    DisplayTitle("Order Menu");
                    Console.WriteLine("1. Choose a product");
                    Console.WriteLine("2. Confirm Order");
                    Console.WriteLine("3. Exit");

                    int choice = GetIntInput("Enter your choice: ");

                    switch (choice)
                    {
                        case 1:
                            string itemName = GetStringInput("Enter item name: ");
                            int quantity = GetIntInput("Enter quantity: ");
                            order.AddItem(inventory, itemName, quantity);
                            break;
                        case 2:
                            order.ProcessOrder(inventory);
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    DisplayTitle("Current Order");
                    order.Items.ForEach(DisplayItem);
                }
            }

            public static void DisplayTitle(string title)
            {
                Console.WriteLine("====================================");
                Console.WriteLine(title);
                Console.WriteLine("====================================");
            }

            public static void DisplayItem(Item item)
            {
                Console.WriteLine($"Name: {item.Name,-20} Quantity: {item.Quantity,3} Price: ${item.Price:0.00}");
            }

            public static int GetIntInput(string message)
            {
                Console.Write(message);
                int input = int.Parse(Console.ReadLine());
                return input;
            }

            public static string GetStringInput(string message)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                return input;
            }
    }
 }