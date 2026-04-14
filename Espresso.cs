class Espresso : IBeverage
{
    private double price = 2.0;

    public double GetPrice()
    {
        Console.WriteLine($"Espresso price: ${this.price:F2}");
        return price;
    }
}