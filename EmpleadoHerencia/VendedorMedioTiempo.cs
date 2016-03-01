using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoHerencia
{
    class VendedorMedioTiempo : Vendedor
    {
        // Constructores
        public VendedorMedioTiempo () { }

        public VendedorMedioTiempo (string nombre, string id, double salario, int edad, int ventas)
            : base(nombre, id, salario, edad, ventas)
        {
            // En caso de que se requieran validaciones o miembros adicionales
            // se colocarían aquí. En este ejemplo no existe nada que adicionar.
        }

        // ¡¡¡¡¡Error de compilación!!!!! No se puede sobrecargar métodos sellados.
        /* public override void DarBono(double cantidad)
        {

        } */
    }
}
