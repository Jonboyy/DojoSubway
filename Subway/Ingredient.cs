namespace Subway;

public class Ingredient
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Ingredient(string name, double price)
    {
        Name = name;
        Price = price;
    }

}