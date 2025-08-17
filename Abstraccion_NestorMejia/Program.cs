using System;

class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new Gerente
        {
            Nombre = "Nestor Mejia",
            ID = 1,
            SalarioBase = 60000,
            BonoAnual = 90000
        };

        Desarrollador desarrollador = new Desarrollador
        {
            Nombre = "Andrea Gamez",
            ID = 2,
            SalarioBase = 40000,
            LenguajePrincipal = "C#"
        };

        Contador contador = new Contador
        {
            Nombre = "Luis Martinez",
            ID = 3,
            SalarioBase = 30000,
            HorasExtras = 10,
            PagoPorHoraExtra = 20
        };

        Empleado[] empleados = { gerente, desarrollador, contador };

        foreach (var empleado in empleados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine($"Salario Anual: {empleado.CalcularSalarioAnual()}\n");
        }
    }
}
