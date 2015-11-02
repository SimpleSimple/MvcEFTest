using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            
        }

        public override void Prepare()
        {
            System.Console.WriteLine("Cheese Pizza");
        }

    }
}
