
public class Program
{
    static List<FoodItem> inventory = new List<FoodItem>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. List All Food Items");
            Console.WriteLine("4. Exit");


            int.TryParse(Console.ReadLine(), out int choice);

            if (choice == 1)
            {
                AddFoodItem();
            }
            else if (choice == 2)
            {
                DeleteFoodItem();
            }
            else if (choice == 3)
            {
                PrintInventory();
            }
            else if (choice == 4)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Please select a valid option.");
            }
        }
    }


    static void AddFoodItem()
    {
        Console.Write("Enter name of the food item: ");
        string name = Console.ReadLine();
        Console.Write("Enter category of the food item: ");
        string category = Console.ReadLine();

        Console.Write("Enter quantity of the food item: ");
        int quantity = int.Parse(Console.ReadLine());


        Console.Write("Enter expiration date (yyyy-mm-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime expirationDate))
        {
            Console.WriteLine("Invalid date format.");
            return;
        }

        inventory.Add(new FoodItem(name, category, quantity, expirationDate));
        Console.WriteLine("Food item added!");
    }

    static void DeleteFoodItem()
    {
        Console.Write("Enter the name of the food item to delete: ");
        string name = Console.ReadLine();
        FoodItem itemToRemove = inventory.Find(item => item.Name == name);
        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            Console.WriteLine("Food item deleted.");
        }
        
    }

    static void PrintInventory()
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("No items in inventory.");
        }
        else
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"Name: {item.Name}, Category: {item.Category}, Quantity: {item.Quantity}, Expiration Date: {item.ExpirationDate.ToShortDateString()}");
            }
        }
    }
}
