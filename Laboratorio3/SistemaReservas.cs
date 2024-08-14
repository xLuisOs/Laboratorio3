using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class SistemaReservas
    {
        private List<Reserva> reservas = new List<Reserva>();
        private int proximoNumeroReserva = 1;

        public void RegistrarReserva(Reserva reserva)
        {
            try
            {
                reserva.Numero = proximoNumeroReserva++;
                reservas.Add(reserva);
                Console.WriteLine("Reserva registrada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar la reserva: {ex.Message}");
            }
        }

        public Reserva BuscarReserva(int numero)
        {
            try
            {
                return reservas.FirstOrDefault(r => r.Numero == numero);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar la reserva: {ex.Message}");
                return null;
            }
        }

        public void MostrarReservas()
        {
            try
            {
                foreach (var reserva in reservas)
                {
                    reserva.MostrarDetalles();
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar las reservas: {ex.Message}");
            }
        }
    }
}
