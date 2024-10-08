internal class Program
{
    private static void Main(string[] args)
    {
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
            Console.WriteLine($"\nResultados del grupo:");
            Console.WriteLine($"Estudiantes que ganaron: {estudiantesGanaron}");
            Console.WriteLine($"Estudiantes que perdieron: {estudiantesPerdieron}");

        }
    }
}