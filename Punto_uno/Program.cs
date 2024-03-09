using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Definir el sueldo base del vendedor y el objetivo de ventas
        const double sueldoBase = 1000000;
        const double objetivoVentas = 1000000;

        // Definir las ventas del vendedor
        double[] ventas = { 500000, 300000, 400000 };

        // Calcular las comisiones por cada venta
        var comisiones = ventas.Select(venta => venta * 0.10);

        // Calcular el total de comisiones
        double totalComisiones = comisiones.Sum();

        // Calcular la venta que generó la mayor comisión
        var ventaMayorComision = ventas[Array.IndexOf(comisiones.ToArray(), comisiones.Max())];

        // Calcular el promedio de las comisiones
        double promedioComisiones = comisiones.Average();

        // Calcular el total recibido en el mes
        double totalMes = sueldoBase + totalComisiones;

        // Determinar si se alcanzó el objetivo de ventas
        bool alcanzoObjetivo = ventas.Sum() >= objetivoVentas;

        // Calcular el total recibido en el mes considerando el beneficio extra
        if (alcanzoObjetivo)
        {
            totalMes += 100000;
            Console.WriteLine("El vendedor ha superado el objetivo del mes y ha ganado el beneficio extra.");
        }
        else
        {
            Console.WriteLine("El vendedor no ha superado el objetivo del mes y no ha ganado el beneficio extra.");
        }



