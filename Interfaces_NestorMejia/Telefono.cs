using System;

public class Telefono : IDispositivoElectronico
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public bool EstaEncendido { get; private set; }

    // Constructor
    public Telefono(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        EstaEncendido = false;
    }

    public void Encender()
    {
        EstaEncendido = true;
        Console.WriteLine($"{Marca} {Modelo} encendido.");
    }

    public void Apagar()
    {
        EstaEncendido = false;
        Console.WriteLine($"{Marca} {Modelo} apagado.");
    }

    public void MostrarEstado()
    {
        string estado = EstaEncendido ? "encendido" : "apagado";
        Console.WriteLine($"Teléfono: {Marca} {Modelo}, Estado: {estado}");
    }
}
