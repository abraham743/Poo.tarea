using System;

namespace estructura_de_datos_poo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // declaro nuevo cliente y lo agrego
            Clienteservices servicio = new Clienteservices();
            Cliente cliente1 = servicio.Agregar();
            Console.Clear();
            servicio.SumaProducto();
            servicio.Imprimir(cliente1);

        }
    }
}
