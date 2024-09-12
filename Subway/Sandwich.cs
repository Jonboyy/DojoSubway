namespace Subway;

public class Sandwich : OrderItem
{
    public List<Ingredient> Ingredients { get; set; }
    

    public Sandwich(List<Ingredient> ingredients)
    {
        Ingredients = ingredients;
        Price = Ingredients.Sum(ingredient => ingredient.Price);
    }

}