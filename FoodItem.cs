﻿public class FoodItem
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
    public DateTime ExpirationDate { get; set; }

    public FoodItem(string name, string category, int quantity, DateTime date)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = date;
    }
}
