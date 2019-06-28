using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    class Program
    {
        static void Main(string[] args)
        {
            //objetos
            VentasCliente clientes = new VentasCliente();

            clientes.Nombre = "Angel";
            clientes.IdCliente = "001";
            clientes.Apellido = "Perez de los Santos";
            clientes.RFC = "AMG";
            clientes.EsCredito = true;
            clientes.Colonia = "Fantino";

            //mostras consola
            Console.WriteLine(clientes.Nombre + " " + clientes.Apellido);
            Console.WriteLine(clientes.RFC);
            Console.WriteLine(clientes.Colonia);
            if (clientes.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito.");
            }
            else
            {
                Console.WriteLine("El cliente no tiene credito.");
            }

            Console.ReadKey();
        }
    }
}
