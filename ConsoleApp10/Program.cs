using System;

namespace EcommerceDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el total de la compra:");
            decimal monto = Convert.ToDecimal(Console.ReadLine());

            if (monto > 1000m)
            {
                decimal descuento = monto * 0.20m;
                monto -= descuento;
                Console.WriteLine($"Se ha aplicado un 20% de descuento. Monto con descuento: ${monto}");
            }
            else if (monto > 500m)
            {
                decimal descuento = monto * 0.10m;
                monto -= descuento;
                Console.WriteLine($"Se ha aplicado un 10% de descuento. Monto con descuento: ${monto}");
            }
            else
            {
                Console.WriteLine($"No se aplica descuento. Monto total: ${monto}");
            }
        }
    }
}
