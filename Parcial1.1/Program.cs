internal class Program
{
    private static void Main(string[] args)
    {
        //Punto 1:Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:

        const double sb = 2000000; // sb: Sueldo base
        const double porc = 0.1; // porc: Porcentaje de comision por venta.
        double venta1, venta2, venta3, SumaVentas, comi1, comi2, comi3, sumacomisiones, SueldoNetoMes, PromComi, TotalPago;
        int VentaMayor;

        Console.Write("Ingrese el valor de la venta #1: ");
        venta1 = Convert.ToDouble(Console.ReadLine());
        comi1 = venta1 * porc;

        Console.Write("Ingrese el valor de la venta #2: ");
        venta2 = Convert.ToDouble(Console.ReadLine());
        comi2 = venta2 * porc;

        Console.Write("Ingrese el valor de la venta #3: ");
        venta3 = Convert.ToDouble(Console.ReadLine());
        comi3 = venta3 * porc;

        //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?
        sumacomisiones = comi1 + comi2 + comi3;
        Console.WriteLine($"Esto sumaste en comisiones este mes {sumacomisiones:C0}, !Felicidades¡");

        //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
        SueldoNetoMes = sb + sumacomisiones;
        Console.WriteLine($"Total neto mes + comisiones {SueldoNetoMes:C0}");

        //¿Cuál fue la venta que le generó la mayor comisión?
        if (comi1 > comi2 && comi1 > comi3)
        {
            VentaMayor = Convert.ToInt32(venta1);
            Console.WriteLine($"La venta por valor de {venta1:C0}, generó la mayor comisión del mes.");
        }
        else if (comi2 > comi1 && comi2 > comi3)
        {
            VentaMayor = Convert.ToInt32(venta2);
            Console.WriteLine($"La venta por valor de {venta2:C0}, generó la mayor comisión del mes.");
        }
        else
        {
            VentaMayor = Convert.ToInt32(venta3);
            Console.WriteLine($"La venta por valor de {venta3:C0}, generó la mayor comisión del mes.");
        }

        //¿Cuál fue el promedio de las comisiones que recibió por cada venta?
        PromComi = sumacomisiones / 3;
        Console.WriteLine($"El valor promedio de comisiones este mes es de {PromComi:C0}");

        //Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes.
        // El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas.

        //Mostrar un mensaje donde indique si ganó o no el beneficio.

        SumaVentas = venta1 + venta2 + venta3;

        if (SumaVentas >= 1000000)
        {
            TotalPago = SueldoNetoMes + 100000;
            Console.Write($"¡Felicidades! cumpliste con la meta mensual de ventas, has ganado un beneficio económico adicional de $ {100000:C0}. Haz recibido un pago total de {TotalPago:C0}");
        }
        else
        {
            TotalPago = SueldoNetoMes;
            Console.Write($"¡Ups! no cumpliste con la meta mensual de ventas este mes, no ganaste el beneficio. Haz recibido un pago total de {TotalPago:C0}");
        }






    }
}