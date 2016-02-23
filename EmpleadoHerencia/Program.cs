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

            Console.ReadLine();
        }
    }
}
