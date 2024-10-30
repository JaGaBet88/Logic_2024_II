using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Evaluativa_0._1
{
    public class Aplicacion
    {
        // Método para iniciar el flujo de la aplicación
        public void Iniciar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese el estrato del estudiante (1, 2 o 3): ");
                int estrato = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de créditos que tomará el estudiante: ");
                int creditos = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el costo por crédito: ");
                decimal costoCredito = decimal.Parse(Console.ReadLine());

                // Crear instancia de Estudiante y calcular matrícula
                Estudiante estudiante = new Estudiante(estrato, creditos, costoCredito);
                Matricula matricula = new Matricula(estudiante);

                // Imprimir el costo de la matrícula y el subsidio
                matricula.CalcularCostoYSubsidio();

                // Preguntar si se desea calcular para otro estudiante
                Console.WriteLine("¿Desea calcular la matrícula de otro estudiante? (s/n): ");
                continuar = Console.ReadLine().ToLower() == "s";
            }
        }
    }
}
