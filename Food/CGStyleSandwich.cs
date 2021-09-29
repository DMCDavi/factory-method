using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Food
{
    public class CGStyleSandwich : Sandwich
    {
        public CGStyleSandwich()
        {
            name = "X-CG";
            bread = "integral";
            cheese = "prato";
            ham = "de frango";
            salad = "sem verdura";
        }
    }
}
