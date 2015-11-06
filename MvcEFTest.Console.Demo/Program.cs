using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            NYStylePizzaStore nyStore = new NYStylePizzaStore();
            var pizza = nyStore.OrderPizza("veggie");
            
        }
    }
}
