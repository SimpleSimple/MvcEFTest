using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
            }
            return pizza;
        }
    }
}
