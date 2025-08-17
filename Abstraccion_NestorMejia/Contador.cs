using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Contador : Empleado
{
    public int HorasExtras { get; set; }
    public double PagoPorHoraExtra { get; set; }

    public override double CalcularSalarioAnual()
    {
        return (SalarioBase * 12) + (HorasExtras * PagoPorHoraExtra);
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, ID: {ID}, Salario Base: {SalarioBase}, Horas Extras: {HorasExtras}, Pago por Hora Extra: {PagoPorHoraExtra}");
    }
}
