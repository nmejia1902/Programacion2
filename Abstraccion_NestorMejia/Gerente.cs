using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Gerente : Empleado
{
    public double BonoAnual { get; set; }

    public override double CalcularSalarioAnual()
    {
        return (SalarioBase * 12) + BonoAnual;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, ID: {ID}, Salario Base: {SalarioBase}, Bono Anual: {BonoAnual}");
    }
}
