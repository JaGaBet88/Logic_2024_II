using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Evaluativa_0._1
{
    internal class Matricula
    {
        // Propiedad
        private Estudiante Estudiante { get; set; } // Instancia de la clase Estudiante

        // Constructor
        public Matricula(Estudiante estudiante)
        {
            Estudiante = estudiante;
        }

        // Método para calcular el costo final y el subsidio, e imprimirlos
        public void CalcularCostoYSubsidio()
        {
            decimal costoFinal = Estudiante.CalcularCostoMatricula(); // Costo final de la matrícula
            decimal subsidio = Estudiante.CalcularSubsidio(); // Subsidio para el estudiante

            Console.WriteLine($"El costo de la matrícula es: {costoFinal:C}");
            Console.WriteLine($"El subsidio es: {subsidio:C}");
        }
    }
}
