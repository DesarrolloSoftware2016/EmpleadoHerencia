using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** La jerarquía de clases Empleado *****");

            // Creando un gerente
            Gerente elGerente = new Gerente("Norman Gonzales", "0318196700001", 50000, 65, 0);
            Console.Write("Ingrese el nombre del gerente: ");
            elGerente.Nombre = Console.ReadLine();
            elGerente.DesplegarEstado();
            elGerente.DarBono(10000);
            elGerente.DesplegarEstado();

            Console.WriteLine("Accediendo al coste de los beneficios: {0}", elGerente.GetCostoBeneficios());

            // Creando un objeto de tipo Vendedor
            Vendedor elVendedor = new Vendedor("Marcos Pereira", "1234567890987", 8000, 35, 30);
            elVendedor.DesplegarEstado();
            elVendedor.DarBono(100);
            elVendedor.DesplegarEstado();

            // Creando un objeto de tipo VendedorMedioTiempo
            VendedorMedioTiempo elVendedorMedioTiempo = new VendedorMedioTiempo("Juan Carlos Perez", "0987654321098", 3000, 19, 15);
            elVendedorMedioTiempo.DesplegarEstado();
            elVendedorMedioTiempo.DarBono(10000);
            elVendedorMedioTiempo.DesplegarEstado();

            Console.ReadLine();
        }
    }
}
