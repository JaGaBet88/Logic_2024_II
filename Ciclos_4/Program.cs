public class Program
{
    private static void Main(string[] args)
    {
        /*22. Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

        - Si el IMC del paciente es menor a 18.5, entonces tiene peso insuficiente.
        - Si el IMC está entre 18.5 y 24.9 se encuentre en la categoría de Peso Saludable.
        - Si el IMC está entre 25.0 y 29.9 entonces tiene sobrepeso.
        - Si el IMC es mayor de 29.9 entonces tiene obesidad.

        Mostrar en pantalla la categoría de cada uno de los pacientes. La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular
        */

        //Valores de Entrada
        double estatura, peso, imc;
        bool continuar = true;
        int n;
        string respuesta;

        while (continuar) //se encarga simplemente de conrtolar si el médico quiere calcular un nuevo grupo de pacientes
        {
            Console.Clear();
            Console.Write("Ingrese el número de pacientes: ");
            n = Convert.ToInt32(Console.ReadLine());

            //El for estará dentro del While....
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nIngrese el peso del paciente # {i + 1} en 'kg': ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Ingrese la estatura del paciente # {i + 1} en 'm': ");
                estatura = Convert.ToDouble(Console.ReadLine());

                //Cálculo del IMC

                imc = peso / Math.Pow(2, estatura); //Esto es lo mismo que poner (estatura * estatura)

                switch (imc) //imc= 27
                {
                    //Esta es la forma de validar una variable si existe dentro de un rango 
                    case double cat when cat < 18.5:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} está en la categoría de 'Peso Insuficiente'");
                        break;

                    case double cat when cat >= 18.5 && cat < 25:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} está en la categoría de 'Peso Saludable'");
                        break;

                    case double cat when cat >= 25 && cat < 30:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} está en la categoría de 'Sobrepeso'");
                        break;

                    case double cat when cat >= 30:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} está en la categoría de 'Obesidad'");
                        break;

                    default:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} no se encuentra en ninguna categoría");
                        break;
                }
            }

            //Retorno al While
            Console.WriteLine("\nSeñor médico: ¿Desea calcular el IMC de más pacientes? (S/N)");
            respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "N")
            {
                continuar = false;
            }
        }
    }
}