﻿using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 42.Desarrolle un algoritmo donde almacene las ventas que obtuvo mensualmente un almacén durante el año 2023.Mostrar por pantalla cada mes con su respectiva venta en pesos y la suma total de ventas de dicho año.*/

        //Declaramos los nuevos arrays:

        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        decimal[] ventas = new decimal[12]; //Desde 0 hasta 11

        decimal suma = 0;

        //Vamos a implementar métodos para trabajar un poco POO:

        //Principios SOLID (Consultar)...

        //Método almacenar ventas

        CapturarVentas(meses, ventas);

        //Método calcular ventas total del año.

        CalcularVentas(ventas, suma);

        //Método para mostrar ventas.
        MostrarVentas();

    }

    private static void CapturarVentas(string[] meses, decimal[] ventas)
    {
        for (int i = 0; i < ventas.Length; i++) 
        {
            Console.WriteLine($"Ingrese las ventas del mes {meses[i]}");
            ventas[i] = Convert.ToDecimal(Console.ReadLine);
        }

    }
    private static void CalcularVentas(decimal[] ventas, decimal suma)
    {
        for(int i = 0;i < ventas.Length; i++)
        {
            suma += ventas[i];
        }
    }
    private static void MostrarVentas()
    {

    }


}