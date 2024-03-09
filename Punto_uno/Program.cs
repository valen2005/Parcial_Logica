using System;
using System.Linq;

namespace Punto_uno
{
    internal class Program
    {
        public void Main(string[] args)
        {

            // Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:
// ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes? ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
// ¿Cuál fue la venta que le generó la mayor comisión?
// ¿Cuál fue el promedio de las comisiones que recibió por cada venta?
//Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde indique si ganó o no el beneficio.

            // definición de variables 

            double sueldoBase = 10000000
            double objetivoVentas = 10000000

                // Definir las ventas del vendedor
        double[] ventas = { 500000, 300000, 400000 };

            // Calcular las comisiones por cada venta
            var comisiones = ventas.Select(venta => venta * 0.10);


            double totalComisiones = 0;
            foreach (var comision in comisiones)
            {
                totalComisiones += comision;

                double totalMes = sueldoBase + totalComisiones;

                bool alcanzoObjetivo = false;
                double totalVentas = 0;
                foreach (var venta in ventas)

                {

                    totalVentas += venta;

                }


                if ( totalVentas >= objetivoVentas)
                {
                    alcanzoObjetivo = true; 

                }
            }


            Console.WriteLine("Hello World!");
        }
    }
}
