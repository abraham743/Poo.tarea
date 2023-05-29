using System;
using estructura_de_datos_poo.Entity;
using estructura_de_datos_poo.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructura_de_datos_poo.Services
{
    public class Clienteservices
    {

       


        
        //agregar los datos del cliente
        public Cliente Agregar()
        {
            try
            {
                Cliente cliente = new Cliente();
                Console.Write("Ingresar Nombre: ");
                cliente.Nombre = Console.ReadLine();
                Console.Write("Ingresar Telefono: ");
                cliente.Telefono = Console.ReadLine();
                Console.Write("Ingresar Correo: ");
                cliente.Correo = Console.ReadLine();
                return cliente;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                throw new Exception("OCURRIO UN ERROR: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Imprimir(Cliente request)
        {
            try
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Datos Personales:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("El Nombre es: " + request.Nombre);
                Console.WriteLine("El Telefono es: " + request.Telefono);
                Console.WriteLine("El Correo es: " + request.Correo);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                throw new Exception("Sucedio un Error " + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // 
        public int SumaProducto()
        {
            try
            {
                int Total = 0;
                Console.WriteLine("Ingresa la cantidad  en pesos de 5 Articulos: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Articulo {0}: ", i);
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Total += numero;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("el Total es :");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Total);
                Console.WriteLine("");
                if (Total >= 5000)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tienes Un Descuento Del 10%");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (Total >= 8000)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tienes Un Descuento De 3 Meses Sin Intereses");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (Total >= 10000)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tienes Un Descuento De 3 Meses ó 6 Meses Sin Intereses");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No tienes descuento disponible");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return Total;
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                throw new Exception("OCURRIO UN ERROR: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
