Console.WriteLine("=== Coffeeteria Test Run ===");
Console.WriteLine();

PrintOrder("Plain Espresso", new Espresso());
PrintOrder("Plain Cappuccino", new Cappuccino());
PrintOrder("Plain Tea", new Tea());

PrintOrder(
	"Espresso + Milk + Cinnamon",
	new Cinnamon(new Milk(new Espresso()))
);

PrintOrder(
	"Cappuccino + Chocolate + Whipped Cream",
	new WhippedCream(new Chocolate(new Cappuccino()))
);

PrintOrder(
	"Tea + Milk + Chocolate + Cinnamon + Whipped Cream",
	new WhippedCream(new Cinnamon(new Chocolate(new Milk(new Tea()))))
);

Console.WriteLine("=== End of Test Run ===");

static void PrintOrder(string description, IBeverage beverage)
{
	Console.WriteLine($"Order: {description}");
	double total = beverage.GetPrice();
	Console.WriteLine($"Total: ${total:F2}");
	Console.WriteLine();
}