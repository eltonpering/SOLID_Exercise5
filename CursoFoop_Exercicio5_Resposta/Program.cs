using System;

namespace SOLID_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzaria p1 = new Pizzaria(new PizzaFactory());
            p1.CriarPizza("mussarela");
            Console.WriteLine("");
            p1.CriarPizza("calabresa");
            Console.ReadLine();
        }
    }
}
