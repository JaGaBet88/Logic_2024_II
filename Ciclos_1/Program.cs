﻿using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Construir un algoritmo que pida n numeros por pantalla, cuando el usuario ingrese un numero negativo, el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo.*/

        //Datos de entrada
        int contador = 0, N_Num;
        bool flag = true;

        //Proceso con ciclo while
        while (flag)
        {
            Console.Write("Ingrese un número: ");
            N_Num = Convert.ToInt32(Console.ReadLine());

            if (N_Num >= 0)
            {
                //Significa que es positivo
                /*contador = contador + 1; // Forma clásica pero obsoleta*/
                contador++; // Forma abreviada
            }
            else
            {
                flag = false;
            }
        }
        Console.WriteLine($"El total de números positivos ingresados es : {contador}");

        //Por lo general el while se usa con banderas ya que no hay un iterador que limite la cantidad de veces que se repetirá el ciclo.
    }
}