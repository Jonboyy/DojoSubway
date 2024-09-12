using Subway;

var restaurant1 = new Restaurant("Gordon Ramsey's kifõzdêje");
var sandwich1 = new Sandwich(new List<Ingredient>() {new Ingredient("Lokolbasz", 2), new Ingredient("Vaginal discharge", 0.1), new Ingredient("egesz durian", 500)});
var uccsi = new Drink("Cola");

restaurant1.AddOrder(uccsi);
restaurant1.AddOrder(sandwich1);

restaurant1.CalculateIncome();

restaurant1.DisplayOrders();


