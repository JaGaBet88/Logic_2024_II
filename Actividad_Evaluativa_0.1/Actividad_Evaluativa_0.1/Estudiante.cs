using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
