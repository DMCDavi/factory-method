using FactoryMethod.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Store
{
    public class SnackBarCG : SnackBar
    {
        protected override Sandwich createSandwich(string type)
        {
            if(type == "X-CG")
            {
                return new CGStyleSandwich();
            } 
            else
            {
                return null;
            }
        }
    }
}
