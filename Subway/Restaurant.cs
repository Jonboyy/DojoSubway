using System.Security.Claims;
using System.Threading.Channels;

namespace Subway;

public class Restaurant
{
    public string Name { get; set; }
    public List<OrderItem> OrderedItems { get; set; } = [];

    public double Income { get; set; } = 0;

    public Restaurant(string name){
        Name = name;
    }

    public void AddOrder(OrderItem order)
    {
        OrderedItems.Add(order);
    }

    public void CalculateIncome()
    {
        Income = OrderedItems.Sum(item => item.Price);
    }

    public void DisplayOrders()
    {
        foreach (var order in OrderedItems)
        {
            if (order is Drink drink)
            {
                Console.WriteLine($"{drink.Flavor} {drink.Price}");
            }

            if (order is Sandwich sandwich)
            {
                sandwich.Ingredients.ForEach(ingredient => Console.WriteLine($"{ingredient.Name}"));
                Console.WriteLine($"Sadwich: {sandwich.Price}");
            }
        }

        Console.WriteLine("Total Income: {0}", Income);
    }
}