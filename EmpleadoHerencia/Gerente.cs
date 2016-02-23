using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoHerencia
{
    class Gerente : Empleado
    {
        // Propiedades
        public int Acciones { get; set; }

        // Constructores
        public Gerente() { }

        public Gerente(string nombre, string id, double salario, int edad, int acciones)
            : base(nombre, id, salario, edad)
        {
            Acciones = acciones;
        }

        // Polimorfismo
        public override void DarBono(double cantidad)
        {
            base.DarBono(cantidad);
            Random aleatorio = new Random();
            Acciones += aleatorio.Next(500);
        }
        
        public override void DesplegarEstado()
        {
            base.DesplegarEstado();
            Console.WriteLine("El número de acciones es {0}", Acciones);
        }
    }
}
