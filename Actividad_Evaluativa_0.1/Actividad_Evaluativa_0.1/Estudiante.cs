using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Evaluativa_0._1
{
    internal class Estudiante
    {

        //Propiedades
        public int Estrato { get; set; }
        public int Creditos { get; set; }
        public decimal CostoCredito { get; set; }

        //Constructor
        public Estudiante(int estrato, int creditos, decimal costoCredito) 
        {
            Estrato = estrato;
            Creditos = creditos;
            CostoCredito = costoCredito;
        }

        //Método para calcular el costo de la matricula
        public decimal CalcularCostoMatricula()
        {
            decimal costoTotal;

            if (Creditos <= 20)
            {
                //Si toma 20 créditos, se calcula con el costo normal por crédito
                costoTotal = Creditos * CostoCredito;
            }
            else
            {
                //Si toma mas de 20 créditos, los créditos adicionales se pagan al doble
                int CreditosExtra = Creditos - 20;
                costoTotal = (20 * CostoCredito) + (CreditosExtra * CostoCredito * 2);
            }

            //Resta el descuento correspondiente basado en el estrato
            return costoTotal - CalcularDescuento(costoTotal);

            //Método para calcular el descuento basado en el estrato
            private decimal CalcularDescuento(decimal costo)
            {
                decimal descuento = 0;

            switch(Estrato) 
            {
                case 1:


            }

    }
}
