using System;

class Program
{
    static void Main(string[] args)
    {
        Telefono telefono = new Telefono("Apple", "iPhone 14");
        Laptop laptop = new Laptop("Dell", "XPS 15", 95);

        telefono.MostrarEstado();
        laptop.MostrarEstado();

        telefono.Encender();
        laptop.Encender();

        telefono.MostrarEstado();
        laptop.MostrarEstado();

        telefono.Apagar();
        laptop.Apagar();
 
        telefono.MostrarEstado();
        laptop.MostrarEstado();
    }
}
