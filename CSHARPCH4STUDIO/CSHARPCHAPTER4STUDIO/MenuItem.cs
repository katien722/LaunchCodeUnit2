namespace CHSTUDIO4RESTAURANTMENU;

public class MenuItem
{

    public char IsNew { get; set; }
      public double Price { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public string Category { get; set; }

    public MenuItem(char isNew, double price, string name, string description, string category)
    {
        IsNew = isNew;
        Price = price;
        Name = name;
        Description = description;
        Category = category;
    }

}
