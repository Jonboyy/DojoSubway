namespace Subway;

public class Drink : OrderItem
{
    public string Flavor { get; set; }

    public Drink(string flavor)
    { 
        Flavor = flavor;
        
        switch (flavor)
        {
            case "Cola":
                Price = 4.00;
                break;
            case "Fanta":
                Price = 3.8;
                break;
            case "IceTea":
                Price = 3.6;
                break;
            default: throw new Exception("Unknown flavor");
        }
    }
}