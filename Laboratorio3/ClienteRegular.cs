using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class ClienteRegular:Cliente
    {
        public ClienteRegular(string nombre, string correo, string telefono)
        : base(nombre, correo, telefono) { }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine("Tipo de Cliente: Regular");
        }
    }
}
