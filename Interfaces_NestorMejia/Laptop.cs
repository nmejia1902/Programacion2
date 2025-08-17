using System;

public class Laptop : IDispositivoElectronico
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public bool EstaEncendido { get; private set; }
    public int NivelBateria { get; set; }

    public Laptop(string marca, string modelo, int nivelBateria)
    {
        Marca = marca;
        Modelo = modelo;
        NivelBateria = nivelBateria;
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
        Console.WriteLine($"Laptop: {Marca} {Modelo}, Estado: {estado}, Nivel de Bateria: {NivelBateria}%");
    }
}
