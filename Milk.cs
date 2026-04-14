class Milk : BeverageDecorator
{
    private double price = 1.0;

    public Milk(IBeverage beverage) : base(beverage)
    {
    }

    public override double GetPrice()
    {
        Console.WriteLine($"Milk price: ${this.price:F2}");
        return this.beverage.GetPrice() + this.price;
    }
}