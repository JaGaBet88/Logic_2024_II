internal class Program
{
    private static void Main(string[] args)
    {
        //Construir por pantalla un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los numeros ingresados.

        int num1, num2, num3;

        Console.WriteLine("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        // Encontrar el mayor, el del medio y el menor
        int mayor, medio, menor;

        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
            medio = (num2 > num3) ? num2 : num3;
            menor = (num2 < num3) ? num2 : num3;
        }
        else if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
            medio = (num1 > num3) ? num1 : num3;
            menor = (num1 < num3) ? num1 : num3;
        }
        else
        {
            mayor = num3;
            medio = (num1 > num2) ? num1 : num2;
            menor = (num1 < num2) ? num1 : num2;
        }

        // Mostrar los resultados
        Console.WriteLine($"Mayor: {mayor}");
        Console.WriteLine($"Medio: {medio}");
        Console.WriteLine($"Menor: {menor}");

    }
}