internal class Program
{
    private static void Main(string[] args)
    {
        //Una fruteria ofrece las manzanas con descuentos según la tabla que hay en archivos de teams. Usted determina el precio del kilo de manzanas como desarrollador. Determinar y mostrar cuanto pagará una persona que compre manzanas en esa fruteria y cual es el descuento que se le aplicó, si fue que se le aplicó alguno.

        //Datos de entrada: Cantidad de kilos de manzanas.
        //Proceso: Calcular el valor neto de manzanas y luego aplicarle el descuento si es que aplica.

        //Declaración de constantes
        const decimal PrecioKgManz = 5000;
        double descuento;

        Console.Write("Ingrese la cantidad de kilos a comprar: ");
        double kgManz = Convert.ToDouble(Console.ReadLine());

        double Subtotal = kgManz * Convert.ToDouble(PrecioKgManz);


    }
}