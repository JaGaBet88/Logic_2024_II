internal class Program
{
    private static void Main(string[] args)
    {
        /*Programe un algoritmo que pida al usuario 2 números por pantalla y que muestre todos los números comprendidos entre ambos números incluyendolos.*/

        //Datos de entrada:
        int num1, num2, menor, mayor;

        Console.Write("Ingrese el primero número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(); 

        //Se aplica un condicional para determinar cual es el numero menor y el mayor ingresados por pantalla
        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else 
        {
            menor = num2;
            mayor = num1;
        }

        for (int i = menor; i <= mayor; i++)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("\n");
    }
}