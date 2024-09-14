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

        //Condicional para evaluar los casos de la ecuación
        if(a == 0 && b == 0)
        {
            Console.WriteLine("Todos los números son solución de la ecuación");
        }
        else if(a == 0)
        {
            Console.WriteLine("La ecuación no tiene solución. ");
        }
        else
        {
            solucion = -b / a;
            Console.WriteLine($"La solución de la ecuación es: x = {solucion}");
        }

    }
}