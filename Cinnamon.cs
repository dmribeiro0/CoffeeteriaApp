class Cinnamon : BeverageDecorator
{
    private double price = 0.5;

    public Cinnamon(IBeverage beverage) : base(beverage)
    {
    }

    public override double GetPrice()
    {
        Console.WriteLine($"Cinnamon price: ${this.price:F2}");
        return this.beverage.GetPrice() + this.price;
    }
}