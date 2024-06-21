using System;

public class InventoryItem
{
    // Properties to store item details
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor to initialize the properties
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Assign values to the properties
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Method to update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice; // Update the price
    }

    // Method to increase the stock quantity of the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity; // Add the additional quantity to the stock
    }

    // Method to sell a quantity of the item
    public void SellItem(int quantitySold)
    {
        // Check if there's enough stock to sell
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold; // Reduce the stock quantity
        }
        else
        {
            Console.WriteLine("Insufficient stock to complete the sale."); // Inform the user if not enough stock
        }
    }

    // Method to check if the item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0; // Return true if the stock quantity is greater than 0
    }

    // Method to print the details of the item
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {ItemName}"); // Print item name
        Console.WriteLine($"ID: {ItemId}"); // Print item ID
        Console.WriteLine($"Price: {Price:C}"); // Print item price, formatted as currency
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}"); // Print item stock quantity
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items initially
        Console.WriteLine("Initial Inventory:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // Sell some items and then print the updated details
        item1.SellItem(10);
        item2.SellItem(2);
        Console.WriteLine("After selling some items:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // Restock items and print the updated details
        item1.RestockItem(7);
        item2.RestockItem(3);
        Console.WriteLine("After restocking items:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // Check if items are in stock and print a message accordingly
        Console.WriteLine($"{item1.ItemName} is in stock: {item1.IsInStock()}");
        Console.WriteLine($"{item2.ItemName} is in stock: {item2.IsInStock()}");
    }
}
