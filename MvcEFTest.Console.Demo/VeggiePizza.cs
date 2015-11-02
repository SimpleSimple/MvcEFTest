using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            
        }

        public override void Prepare()
        {
            System.Console.WriteLine("Veggie Pizza");
        }


    }
}
