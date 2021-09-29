using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Food
{
    public abstract class Sandwich
    {
        public string name { get; set; }
        public string bread { get; set; }
        public string cheese { get; set; }
        public string ham { get; set; }
        public string salad { get; set; }
        public void prepare()
        {
            Console.WriteLine(
                "=====================\n" +
                $"{name}:\n" +
                $"Pão {bread}\n" +
                $"Queijo {cheese}\n" +
                $"Presunto {ham}\n" +
                $"Salada {salad}\n" +
                "====================="
            );
        }
    }
}
