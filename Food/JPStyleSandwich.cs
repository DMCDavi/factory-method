using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Food
{
    public class JPStyleSandwich : Sandwich
    {
        public JPStyleSandwich()
        {
            name = "X-JP";
            bread = "francês";
            cheese = "mussarela";
            ham = "de frango";
            salad = "com verdura";
        }
    }
}
