using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoHerencia
{
    abstract class Empleado
    {
        protected string nombreEmpleado;
        protected string idEmpleado;
        protected double salarioActual;
        protected int edadEmpleado;

        // Variable miembro constante, accesible sólamente
        // desde la clase, no accesible por el objeto.
        public const double ihss = 0.07;

        // Agregar propiedades .NET
        public string Nombre
        {
            get { return nombreEmpleado; }
            set
            {
                if (value.Length < 10)
                    Console.WriteLine("¡Error! El nombre no puede ser menor a 10 caracteres...");
                else
                    nombreEmpleado = value;
            }
        }

        public string Id
        {
            get { return idEmpleado; }
            set
            {
                if (value.Length != 13)
                    Console.WriteLine("¡Error! El ID es incorrecto. Debe contener 13 caracteres...");
                else
                    idEmpleado = value;
            }
        }

        public double Pago
        {
            get { return salarioActual; }
            set { salarioActual = value; }
        }

        public int Edad
        {
            get { return edadEmpleado; }
            set
            {
                if (value > 0)
                    edadEmpleado = value;
                else
                    Console.WriteLine("¡Error! La edad no puede ser negativa ni cero...");
            }
        }

        // Constructores
        public Empleado() { }

        public Empleado(string nombre, string id, double salario, int edad)
        {
            // Utilizando las propiedades reduce la cantidad
            // de código para validaciones y los errores también
            Nombre = nombre;
            Id = id;
            Pago = salario;
            Edad = edad;
        }

        // Métodos
        // Este método puede ser "sobreescrito"por una clase derivada
        public virtual void DarBono(double cantidad)
        {
            salarioActual += cantidad;
        }

        public virtual void DesplegarEstado()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Identidad: {0}", Id);
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine("Salario: {0}", Pago);
        }

        // Un empleado contiene un paquete de beneficios
        // a esta relación de herencia se le conoce como delegación/agregación
        // Los dos tipos de herencia C# (is a - has a)
        protected PaqueteBeneficios beneficiosEmpleado = new PaqueteBeneficios();
    }
}
