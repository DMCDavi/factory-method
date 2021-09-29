using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Food
{
    public class RTStyleSandwich : Sandwich
    {
        public RTStyleSandwich()
        {
            name = "X-RT";
            bread = "bola";
            cheese = "cheddar";
            ham = "de peru";
            salad = "sem verdura";
        }
    }
}
