internal class Program
{
    private static void Main(string[] args)
    {
        /*21. Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa. DONE*/

        //Variables
        double num1, num2;
        int opcion;
        double resultado = 0;
        bool continuar = true;

        do
        {
            Console.Write("Ingresar el primer número: ");
            num1 = double.Parse(Console.ReadLine()); //Double parse es exactamente lo mismo que el convert.ToDouble
            //Realizo toda la lógica del código

            Console.Write("Ingresar el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---Seleccione una operación aritmetica---");
            Console.WriteLine("---1. Sumar                           ---");
            Console.WriteLine("---2. Restar                          ---");
            Console.WriteLine("---3. Multiplicar                     ---");
            Console.WriteLine("---4. Dividir                         ---");
            Console.WriteLine("---5. Sumar                           ---");
            Console.WriteLine("---0. Salir                           ---");
            Console.WriteLine("-----------------------------------------");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //Aqui ingresamos la lógica para implementar el caso 1 y después colocamos la palabra "break"//
                    resultado = num1 + num2;
                    Console.WriteLine($"Suma: {num1} + {num2} = {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resta: {num1} - {num2} = {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Multiplicación: {num1} x {num2} = {resultado}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"División: {num1} / {num2} = {resultado}");
                    }
                    else
                    { 
                        Console.WriteLine("Error: No se puede dividir por cero");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        
        }
        while (continuar);
    }
}