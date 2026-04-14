class Cappuccino : IBeverage
{
    private double price = 3.0;

    public double GetPrice()
    {
        Console.WriteLine($"Cappuccino price: ${this.price:F2}");
        return price;
    }
}