using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_POO
{
    public class Personas
    {
        //Propiedades de mi clase personas.

        public string Nombre { get; set; } //Forma de definir las propiedades getters and setters
        public int Edad { get; set; }

        //Método de mi clase personas.

        //Esta es la forma de crear un método en C#
        //Modificador de acceso + tipo de dato que retorna el método + nombre del método + sección de parametros ()
        //El void significa que el método no retorna nada
        public void Presentar()
        {
            Console.WriteLine($"Hola mi nombre es {Nombre} y tengo {Edad} años.");
        }

        public void EsMayorDeEdad()
        {
            if (Edad >= 18)
            {
                Console.WriteLine("Soy mayor de edad");
            }
            else
            {
                Console.WriteLine("Soy menor de edad");
            }

        }
    }
}
