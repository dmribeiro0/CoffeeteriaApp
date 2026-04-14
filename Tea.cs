class Tea : IBeverage
{
    private double price = 1.5;

    public double GetPrice()
    {
        Console.WriteLine($"Tea price: ${this.price:F2}");
        return price;
    }
}