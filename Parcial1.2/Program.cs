using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Escriba un programa que pida los coeficientes de una ecuación de primer grado (ax + b = 0) y muestre la solución.
        // Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los números sean solución. La fórmula de las soluciones es x = -b / a

        double a, b, solucion; //Declaración de variables

        //Solicitar los coeficientes de la ecuacion
        Console.Write("Ingrese el valor de 'a' (coeficiente de x): ");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese el valor de 'b' (constante): ");
        b = Convert.ToDouble(Console.ReadLine());


    }
}