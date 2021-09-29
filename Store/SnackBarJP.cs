using FactoryMethod.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Store
{
    public class SnackBarJP : SnackBar
    {
        protected override Sandwich createSandwich(string type)
        {
            if (type == "X-JP")
            {
                return new JPStyleSandwich();
            }
            else
            {
                return null;
            }
        }
    }
}
