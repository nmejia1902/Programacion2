using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo(5.0);
        Rectangulo rectangulo = new Rectangulo(4.0, 6.0);

        List<Forma> formas = new List<Forma>();
        formas.Add(circulo);
        formas.Add(rectangulo);

        // Polimorfismo

        foreach (Forma forma in formas)
        {
            Console.WriteLine($"Forma: {forma.Nombre}, Área: {forma.CalcularArea():F2}");
        }
    }
}
