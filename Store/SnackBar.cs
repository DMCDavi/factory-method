using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Food;

namespace FactoryMethod.Store
{
    public abstract class SnackBar
    {
        public Sandwich orderSandwich(string type)
        {
            Sandwich sandwich;
            sandwich = createSandwich(type);
            sandwich.prepare();
            return sandwich;
        }

        protected abstract Sandwich createSandwich(string type);
    }
}
