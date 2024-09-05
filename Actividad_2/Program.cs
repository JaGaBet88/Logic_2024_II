internal class Program
{
    private static void Main(string[] args)
    {
        //2. Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.

        double seg1, seg2, seg3;
        bool istriangle;
        string msj;

        //Pedir los datos:

        Console.Write("Ingrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //Proceso de validación

        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    istriangle = true;
                }
            }
        }