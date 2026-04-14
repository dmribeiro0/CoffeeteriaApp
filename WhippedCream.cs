class WhippedCream : BeverageDecorator
{
    private double price = 2.5;

    public WhippedCream(IBeverage beverage) : base(beverage)
    {
    }

    public override double GetPrice()
    {
        Console.WriteLine($"Whipped cream price: ${this.price:F2}");
        return this.beverage.GetPrice() + this.price;
    } 
}