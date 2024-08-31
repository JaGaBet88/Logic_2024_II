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
        d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        //Formas de concatenación. Se recomiendan la segunda y la tercera, la primera hace mas lenta la concatenación.

        Console.WriteLine("La distancia entre los pares ordenados (" + x1 + "," + y1 + ") y (" + x2 + "," + y2 + ") es: " + d);
        Console.WriteLine(" ");
        Console.WriteLine($"La distancia entre los pares ordenados ({x1},{y1}) y ({x2},{y2}) es: {d}");
        Console.WriteLine(" ");
        Console.WriteLine(String.Format("La distancia entre los pares ordenados ({0},{1}) y ({2},{3}) es: {4}", x1, y1, x2, y2, d));
        Console.WriteLine(" ");
    }
}