using System;
using System.Collections.Generic;


class Drink
{

    public DrinkName Name {get;set;}
    public double Price {get;set;}

    public Drink(DrinkName drinkName)
    {
        this.Name = drinkName;
        switch (drinkName)
        {
            case DrinkName.Water:
                Price = 0.70;
                break;
            case DrinkName.Coca:
                Price = 1.00;
                break;
            case DrinkName.IceTea:
                Price = 1.00;
                break;
            case DrinkName.Fanta:
                Price = 1.00;
                break;
        }
    }

    public enum DrinkName
    {
        Water,
        Coca,
        IceTea,
        Fanta
    }
}