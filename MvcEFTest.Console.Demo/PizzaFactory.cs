using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public abstract class PizzaFactory
    {
        public PizzaFactory() { }

        public static void CreatePizza(string type)
        {
            switch (type) { 
                case "china":

            }
        }
    }
}
