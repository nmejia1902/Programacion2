using System;

public abstract class Empleado
{
    public string Nombre { get; set; }
    public int ID { get; set; }
    public double SalarioBase { get; set; }

    public abstract double CalcularSalarioAnual();
    public abstract void MostrarInformacion();
}
