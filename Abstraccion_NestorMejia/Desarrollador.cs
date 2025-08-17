using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Desarrollador : Empleado
{
    public string LenguajePrincipal { get; set; }

    public override double CalcularSalarioAnual()
    {
        return SalarioBase * 12;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, ID: {ID}, Salario Base: {SalarioBase}, Lenguaje Principal: {LenguajePrincipal}");
    }
}
