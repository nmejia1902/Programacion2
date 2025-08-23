using System;

class Program
{
    static void Main()
    {
        int cantidadNotas = 0;
        double sumaNotas = 0;

        while (true)
        {
            Console.Write("Ingrese la cantidad de notas a promediar: ");
            try
            {
                cantidadNotas = int.Parse(Console.ReadLine());

                if (cantidadNotas <= 0)
                {
                    throw new Exception("El número de notas debe ser mayor que cero.");
                }

                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un número entero válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        for (int i = 0; i < cantidadNotas; i++)
        {
            while (true)
            {
                Console.Write($"Ingrese la nota #{i + 1} (entre 0 y 100): ");
                try
                {
                    double nota = double.Parse(Console.ReadLine());

                    if (nota < 0 || nota > 100)
                    {
                        throw new Exception("La nota debe estar entre 0 y 100.");
                    }

                    sumaNotas += nota;
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar un número válido (puede tener decimales).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        try
        {
            double promedio = sumaNotas / cantidadNotas;
            Console.WriteLine($"\nEl promedio de las notas es: {promedio:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado al calcular el promedio: {ex.Message}");
        }
    }
}
