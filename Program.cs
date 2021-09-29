using FactoryMethod.Store;
using FactoryMethod.Food;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SnackBar snackBarCG = new SnackBarCG();
            SnackBar snackBarJP = new SnackBarJP();
            SnackBar snackBarRT = new SnackBarRT();

            Sandwich sandwich = snackBarCG.orderSandwich("X-CG");
            Console.WriteLine($"Davi pediu um {sandwich.name}\n");
            sandwich = snackBarJP.orderSandwich("X-JP");
            Console.WriteLine($"João pediu um {sandwich.name}\n");
            sandwich = snackBarRT.orderSandwich("X-RT");
            Console.WriteLine($"Vagner pediu um {sandwich.name}\n");
        }
    }
}
