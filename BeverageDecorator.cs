class BeverageDecorator : IBeverage
{
    protected IBeverage beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        this.beverage = beverage;
    }

    public virtual double GetPrice()
    {
        return beverage.GetPrice();
    }
}