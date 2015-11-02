using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcEFTest.Console.Demo
{
    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException("Pepperon");
        }
    }
}
