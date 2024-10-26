internal class Program
{
    private static void Main(string[] args)
    {
        /* Juego:
         * Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en adivinar un número N aleatorio que el sistema escoge de un determinado rango y lo guarda en memoria sin ser revelado.

         * Por ejemplo: El sistema escoge aleatoriamente un número entre 0 y 100, ese número NO SE PUEDE REVELAR ya que es el número que se adivinará, por ende, dicho número se almacenará en memoria. Los participantes comenzarán en orden a jugar y se turnarán para ingresar por pantalla un número N hasta acertar el número oculto y salir ganador.
         
        El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y máximo 4 integrantes. Dependiendo de la cantidad de jugadores, el número N aleatorio se generará en los siguientes rangos:

        - Si participan 2 jugadores, el número N aleatorio se generará entre 0 y 50
        - Si participan 3 jugadores, el número N aleatorio se generará entre 0 y 100
        - Si participan 4 jugadores, el número N aleatorio se generará entre 0 y 200

        Cada jugador comenzará su turno intentando adivinar ese número N aleatorio. El programa deberá mostrarle al jugador la siguiente información:

        - Si el número ingresado es mayor al número aleatorio, entonces mostrar por pantalla la palabra “MENOR” y darle la oportunidad al siguiente jugador.
        - Si el número ingresado es menor al número aleatorio, entonces mostrar por pantalla la palabra “MAYOR” y darle la oportunidad al siguiente jugador.
        - Si el número ingresado coincide con el número aleatorio, entonces mostrar por pantalla la palabra “¡HAS GANADO!”. Aquí ya finaliza el juego.

        El programa deberá estar en capacidad de pedir a los jugadores si desean un nuevo “tirito” para volver a jugar y borrar consola, de lo contrario, finalizar el programa.*/

        //Variables
        bool JugarDeNuevo = true;

        while (JugarDeNuevo)
        {
            Console.Clear(); //Siempre limpiar la consola al comenzar de nuevo
            Console.WriteLine("Bienvenidos al juego 'Adivina el número'!");
            Console.WriteLine("¿Cuántos jugadores participaran? (2-4)");

            int Jugadores = 0;

            //Validación para el número de jugadores
            while (Jugadores < 2 || Jugadores > 4)
            {
                if (int.TryParse(Console.ReadLine(), out Jugadores))
                {
                    if (Jugadores < 2 || Jugadores > 4)
                    {
                        Console.WriteLine("El número de jugadores debe ser entre 2 y 4");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número entre 2 y 4.");
                }
            }

            //Definir el rango según la cantidad de jugadores

            int RangoMaximo = 0;

            switch (Jugadores)
            {
                case 2:
                    RangoMaximo = 50;
                    break;
                case 3:
                    RangoMaximo = 100;
                    break;
                case 4:
                    RangoMaximo = 200;
                    break;
            }

            //Generar un número aleatorio
            Random random = new Random();
            int NumeroAleat = random.Next(0,RangoMaximo + 1);

            bool numeroAdivinado = false;
            int JugadorAct = 1;

            //Ciclo principal del juego
            while (!numeroAdivinado)
            {
                Console.WriteLine($"Jugador {JugadorAct}, es tu turno. Ingresa un número entre 0 y {RangoMaximo}: ");
                int NumeroIngresado = 0;

                //Validación del número ingresado
                while (!int.TryParse(Console.ReadLine(),out NumeroIngresado) || NumeroIngresado < 0 || NumeroIngresado > RangoMaximo)
                {
                    Console.WriteLine($"Entrada inválida. Debes ingresar un número entre 0 y {RangoMaximo}. Inténtalo de nuevo: ");
                }

                //Comparación del número ingresado con el número aleatorio
                if(NumeroIngresado < NumeroAleat)
                {
                    Console.WriteLine("MAYOR");
                }
                else if (NumeroIngresado > NumeroAleat) 
                {
                    Console.WriteLine("MENOR");
                }
                else
                {
                    Console.WriteLine($"¡Has ganado, jugador # {JugadorAct}!");
                    numeroAdivinado = true;
                }

                //Cambiar de jugador si no ha ganado
                if (!numeroAdivinado)
                {
                    JugadorAct = (JugadorAct % Jugadores) + 1; //Rotación entre jugadores
                }

            }

            //Preguntar si desean volver a jugar
            Console.WriteLine("¿Jugar de nuevo? (s/n)");
            string respuesta = Console.ReadLine().ToUpper();

            JugarDeNuevo = respuesta == "S";
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
    }
}