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
            case drinkName.Water:
                Price = 0.70;
                break;
            case drinkName.Coca:
                Price = 1.00;
                break;
            case drinkName.IceTea:
                Price = 1.00;
                break;
            case drinkName.Fanta:
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