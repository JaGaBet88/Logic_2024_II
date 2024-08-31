internal class Program
{
    private static void Main(string[] args)
    {
        //Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.

        //Datos de entrada
        //Declarar las variables, en este caso son 4:
        double x1, x2, y1, y2, d;

        //Inicializacion de variables pidiendo valores por pantalla:
        Console.Write("Por favor ingrese el valor de x1: "); //Esta es la forma de leer en pantalla
        x1 = Convert.ToDouble(Console.ReadLine());//Esta es la forma de escribir en pantalla

        Console.Write("Por favor ingrese el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingrese el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favor ingrese el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        //Proceso cálculo de la variable "d";

        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);

        double suma = x + y;

        //La clase math tiene muchos métodos, entre ellos el método Sqrt, este señor recibe un parámetro dentro de sus (), ese parametro es el numero que yo le mando al método para que me saque la raíz cuadrada.
        d = Math.Sqrt(suma);

        //Formas de concatenación. Se recomiendan la segunda y la tercera, la primera hace mas lenta la concatenación.

        Console.WriteLine("La distancia entre los pares ordenados (" + x1 + "," + y1 + ") y (" + x2 + "," + y2 + ") es: " + d);
        Console.WriteLine(" ");
        Console.WriteLine($"La distancia entre los pares ordenados ({x1},{y1}) y ({x2},{y2}) es: {d}");
        Console.WriteLine(" ");
        Console.WriteLine(String.Format("La distancia entre los pares ordenados ({0},{1}) y ({2},{3}) es: {4}", x1, y1, x2, y2, d));
        Console.WriteLine(" ");
    }
}