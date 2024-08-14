using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Reserva
    {
        public int Numero { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public List<Plato> Platos { get; set; }
        public Cliente Cliente { get; set; }

        public Reserva(int numero, string fecha, string hora, Cliente cliente)
        {
            Numero = numero;
            Fecha = fecha;
            Hora = hora;
            Cliente = cliente;
            Platos = new List<Plato>();
        }

        public void AgregarPlato(Plato plato)
        {
            Platos.Add(plato);
        }

        public double CalcularTotal()
        {
            double total = Platos.Sum(plato => plato.Precio);

            if (Cliente is ClienteVIP vip)
            {
                total -= total * vip.Descuento;
            }

            return total;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Reserva No: {Numero}, Fecha: {Fecha}, Hora: {Hora}");
            Console.WriteLine($"Cliente: {Cliente.Nombre}, Tipo: {(Cliente is ClienteVIP ? "VIP" : "Regular")}");
            Console.WriteLine("Platos:");

            foreach (var plato in Platos)
            {
                Console.WriteLine($"- {plato.Nombre}: ${plato.Precio}");
            }

            Console.WriteLine($"Total: ${CalcularTotal():0.00}");
        }
    }
}
