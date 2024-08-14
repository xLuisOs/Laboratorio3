using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class ClienteVIP : Cliente
    {
        public double Descuento { get; set; }

        public ClienteVIP(string nombre, string correo, string telefono, double descuento)
            : base(nombre, correo, telefono)
        {
            Descuento = descuento;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tipo de Cliente: VIP, Descuento: {Descuento * 100}%");
        }
    }
}
