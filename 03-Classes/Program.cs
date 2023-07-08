using System;
using Classes.Herança;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ponto p1 = new Ponto(10, 20);
            var testing = p1.LogOnScreen();
            Console.WriteLine(testing);
        }
    }
}
