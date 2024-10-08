internal class Program
{
    private static void Main(string[] args)
    {

        /* Sistema de evaluación de notas de estudiantes:
         * El programa permite ingresar las notas de varios estudiantes, calcular su promedio y luego clasificar a cada estudiante en diferentes categorías de desempeño académico. Al final, se le pregunta al usuario si quiere ingresar otro grupo de estudiantes.
           
        Reglas:

          - Si el promedio del estudiante es mayor o igual a 4.5, está en la categoría Excelente.
          - Si el promedio está entre 4.0 y 4.4, está en la categoría Sobresaliente.
          - Si el promedio está entre 3.5 y 3.9, está en la categoría Bueno.
          - Si el promedio es menor a 3.5, está en la categoría Insuficiente.

         Adicional, contar cuántos estudiantes ganaron y cuántos perdieron.*/

        bool nuevoGrupo = true;

        while (nuevoGrupo)
        {
            Console.Clear(); //Limpiar consola al comenzar un nuevo grupo
            Console.WriteLine("Sistema de evaluación de notas de estudiantes");

            int cantidadEstudiantes = 0;
            int estudiantesGanaron = 0;
            int estudiantesPerdieron = 0;

            //Solicitar la cantidad de estudiantes
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadEstudiantes) || cantidadEstudiantes <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido de estudiantes (mayor que 0): ");
            }

            //Procesar las notas de los estudiantes
            for (int i = 1; i <= cantidadEstudiantes; i++)
            {
                double sumaNotas = 0;
                double promedio = 0;
                int cantidadNotas = 0;

                Console.WriteLine($"Estudiante {i}: Ingrese la cantidad de notas: ");
                while (!int.TryParse(Console.ReadLine(),out cantidadNotas) || cantidadNotas <= 0)
                {
                    Console.WriteLine("Por favor, ingrese una cantidad valida de notas (Mayor que 0): ");
                }

                //Ingresar las notas y calcular la suma
                for (int j = 1; j <= cantidadNotas; j++)
                {
                    double nota = 0;
                    Console.WriteLine($"Ingrese la nota {j} (de 0.0 a 5.0): ");
                    while(!double.TryParse(Console.ReadLine(),out nota) || nota < 0.0 || nota > 5.0)
                    {
                        Console.WriteLine("Nota inválida. Ingrese una nota entre 0.0 y 5.0");
                    }
                    sumaNotas += nota;
                }

                //Calcular el promedio
                promedio += sumaNotas / cantidadNotas;
                Console.WriteLine($"El promedio del estudiante {i} es: {promedio:F2}");

                //Clasificación según el promedio
                if(promedio >= 4.5)
                {
                    Console.WriteLine("Categoría: Excelente");
                    estudiantesGanaron++;
                }
                else if(promedio >= 4.0 && promedio < 4.5)
                {
                    Console.WriteLine("Categoría: Sobresaliente");
                    estudiantesGanaron++;
                }
                else if(promedio >= 3.5 && promedio < 4.0)
                {
                    Console.WriteLine("Categoría: Bueno");
                    estudiantesGanaron++;
                }
                else
                {
                    Console.WriteLine("Categoría: Insuficiente");
                    estudiantesPerdieron++;
                }
            }

            //Mostrar los resultados finales
            Console.WriteLine($"Estudiantes que ganaron: {estudiantesGanaron}");
            Console.WriteLine($"Estudiantes que perdieron: {estudiantesPerdieron}");

            //Preguntar si se desea evaluar otro grupo de estudiantes
            Console.WriteLine("\n¿Desea ingresar otro grupo de estudiantes? (s/n): ");
            string respuesta = Console.ReadLine().ToUpper();
            nuevoGrupo = respuesta == "S";
        }

        Console.WriteLine("Gracias por usar el sistema de evaluación. ¡Hasta la próxima!");
    }
}