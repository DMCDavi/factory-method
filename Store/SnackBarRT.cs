using FactoryMethod.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Store
{
    public class SnackBarRT : SnackBar
    {
        protected override Sandwich createSandwich(string type)
        {
            if (type == "X-RT")
            {
                return new RTStyleSandwich();
            }
            else
            {
                return null;
            }
        }
    }
}
