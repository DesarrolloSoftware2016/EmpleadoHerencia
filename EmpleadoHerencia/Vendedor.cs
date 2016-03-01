using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoHerencia
{
    class Vendedor : Empleado
    {
        // Propiedad automática
        public int NumeroVentas { get; set; }

        // Constructores
        public Vendedor() { }

        public Vendedor(string nombre, string id, double salario, int edad, int ventas)
            : base(nombre, id, salario, edad)
        {
            NumeroVentas = ventas;
        }

        // Métodos

        // El bono de un vendedor está influenciado por el
        // número de ventas que realiza, vamos a "sobreescribir" el
        // método de la clase base empleado (polimorfismo).
        public override sealed void DarBono(double cantidad)
        {
            int bonoVentas = 0;
            if (NumeroVentas > 0 && NumeroVentas <= 100)
                bonoVentas = 250;
            else
            {
                if (NumeroVentas > 100 && NumeroVentas <= 200)
                    bonoVentas = 320;
                else
                    bonoVentas = 500;
            }

            base.DarBono(cantidad * bonoVentas);
        }

        public override void DesplegarEstado()
        {
            base.DesplegarEstado();
            Console.WriteLine("El número de ventas es: {0}", NumeroVentas);
        }
    }
}
