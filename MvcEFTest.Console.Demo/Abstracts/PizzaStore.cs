using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public abstract class PizzaStore
    {
        public PizzaStore() { }

        //public sealed Pizza OrderPizza(string type)
        //{
        //    Pizza pizza;

        //    pizza = CreatePizza(type);

        //    return pizza;
        //}

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
