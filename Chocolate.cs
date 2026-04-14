class Chocolate : BeverageDecorator
{
    private double price = 1.0;

    public Chocolate(IBeverage beverage) : base(beverage)
    {
    }

    public override double GetPrice()
    {
        Console.WriteLine($"Chocolate price: ${this.price:F2}");
        return this.beverage.GetPrice() + this.price;
    }
}