using System;
using System.Collections.Generic;
public class CoffeeMachine
{
    private IList<CoffeeType> coffeesSold;

    private int currMoney;

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }

    public IList<CoffeeType> CoffeesSold
    {
        get
        {
            return this.coffeesSold;
        }
    }

    public void BuyCoffee(string size, string type)
    {
        Enum.TryParse(size, out CoffeePrice currSize);
        Enum.TryParse(type, out CoffeeType currType);

        if (this.currMoney >= (int)currSize)
        {
            this.currMoney -= (int)currSize;
            this.coffeesSold.Add(currType);
        }
    }

    public void InsertCoin(string coin)
    {
        Enum.TryParse(coin, out Coin currCoin);
        this.currMoney += (int)currCoin;

    }
}

