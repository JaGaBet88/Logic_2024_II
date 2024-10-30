using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Evaluativa_0._1
{
    public class Estudiante
    {
        // Propiedades
        public int Estrato { get; set; } // Estrato socioeconómico del estudiante
        public int Creditos { get; set; } // Cantidad de créditos a tomar
        public decimal CostoCredito { get; set; } // Costo de cada crédito

        // Constructor
        public Estudiante(int estrato, int creditos, decimal costoCredito)
        {
            Estrato = estrato;
            Creditos = creditos;
            CostoCredito = costoCredito;
        }

        // Método para calcular el costo de la matrícula
        public decimal CalcularCostoMatricula()
        {
            decimal costoTotal;

            if (Creditos <= 20)
            {
                // Si toma 20 o menos créditos, se calcula con el costo normal por crédito
                costoTotal = Creditos * CostoCredito;
            }
            else
            {
                // Si toma más de 20 créditos, los créditos adicionales se pagan al doble
                int creditosExtra = Creditos - 20;
                costoTotal = (20 * CostoCredito) + (creditosExtra * CostoCredito * 2);
            }

            // Resta el descuento correspondiente basado en el estrato
            return costoTotal - CalcularDescuento(costoTotal);
        }

        // Método para calcular el descuento basado en el estrato del estudiante
        private decimal CalcularDescuento(decimal costo)
        {
            decimal descuento = 0;

            switch (Estrato)
            {
                case 1:
                    descuento = costo * 0.80m; // Descuento del 80% para estrato 1
                    break;
                case 2:
                    descuento = costo * 0.50m; // Descuento del 50% para estrato 2
                    break;
                case 3:
                    descuento = costo * 0.30m; // Descuento del 30% para estrato 3
                    break;
                default:
                    Console.WriteLine("Opcion no válida")
            }

            return descuento;
        }

        // Método para calcular el subsidio de alimentación y transporte
        public decimal CalcularSubsidio()
        {
            decimal subsidio = 0;

            if (Estrato == 1)
            {
                subsidio = 200000; // Subsidio para estrato 1
            }
            else if (Estrato == 2)
            {
                subsidio = 100000; // Subsidio para estrato 2
            }

            return subsidio;
        }
    }

}

