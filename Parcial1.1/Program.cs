﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Punto 1:Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:

        //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?
        //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
        //¿Cuál fue la venta que le generó la mayor comisión?
        //¿Cuál fue el promedio de las comisiones que recibió por cada venta?

        //Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes.
        // El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas.

        //Mostrar un mensaje donde indique si ganó o no el beneficio.

        const decimal sb = 2000000; // sb: Sueldo base
        const double porc = 0.1; // porc: Porcentaje de comision por venta.
        double venta1,venta2,venta3,comi1,comi2,comi3;

        Console.Write("Ingrese el valor de la venta #1: ");
        venta1 = Convert.ToDouble(Console.ReadLine());
            comi1 = venta1 * porc;

        Console.Write("Ingrese el valor de la venta #2: ");
        venta2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese el valor de la venta #3: ");
        venta3 = Convert.ToDouble(Console.ReadLine());





    }
}