﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    /*****************************************************************
    * Name: Bill Adams
    * Project: Program 3
    * Date: 12/8/2016
    * Description: Order pizza and other items.
    * **************************************************************/
    class Specials : Product
    {
        private string mType;

        public Specials()
        {

        }

        public Specials(int id, string description, string type)
            : base(id, description)
        {
            this.Type = type;
            this.Price = GetSpecialPrice();
        }

        public string Type
        {
            get
            {
                return mType;
            }
            set
            {
                mType = value;
            }
        }

        public decimal GetSpecialPrice()
        {
            decimal totalCost = 0.0M;
            string[] toppings = new string[1];
            Pizza pizza;
            Salad salad;
            Drink drink;
            decimal pizzaCost, saladCost, drinkCost;

            if (this.Type == "Special1")
            {
                toppings[0] = "Hamburger";

                pizza = new Pizza(107, "Pizza", "Medium", toppings);
                pizzaCost = pizza.GetPizzaPrice();

                salad = new Salad(107, "Salad", "House");
                saladCost = salad.GetSaladPrice();

                drink = new Drink(107, "Drink", "Medium");
                drinkCost = drink.GetDrinkPrice();
            }
            else
            {
                toppings[0] = "Cheese";

                pizza = new Pizza(107, "Pizza", "Medium", toppings);
                pizzaCost = pizza.GetPizzaPrice();

                salad = new Salad(107, "Salad", "Insalata");
                saladCost = salad.GetSaladPrice();

                drink = new Drink(107, "Drink", "Medium");
                drinkCost = drink.GetDrinkPrice();
            }

            totalCost = pizzaCost + saladCost + drinkCost;

            // 10% discount
            totalCost /= 1.10M;

            return totalCost;
        }

        public override string GetDisplayText()
        {
            return this.Description + " (" + this.Type + ") - " + this.Price.ToString("c");
        }
    }
}
