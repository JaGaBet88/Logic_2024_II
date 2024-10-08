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
            }

        }
    }
}