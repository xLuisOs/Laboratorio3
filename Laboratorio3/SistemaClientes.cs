using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class SistemaClientes
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                clientes.Add(cliente);
                Console.WriteLine("Cliente agregado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el cliente: {ex.Message}");
            }
        }

        public Cliente BuscarCliente(string nombre)
        {
            try
            {
                return clientes.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar el cliente: {ex.Message}");
                return null;
            }
        }

        public void MostrarClientes()
        {
            try
            {
                foreach (var cliente in clientes)
                {
                    cliente.MostrarDetalles();
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar los clientes: {ex.Message}");
            }
        }
    }
}
