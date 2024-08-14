using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string correo, string telefono)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, Correo: {Correo}, Teléfono: {Telefono}");
        }
    }
}
