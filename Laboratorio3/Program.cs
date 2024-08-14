using Laboratorio3;

class program
{
    static void Main(string[] args)
    {
        SistemaClientes sistemaClientes = new SistemaClientes();
        SistemaReservas sistemaReservas = new SistemaReservas();

        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Registrar Cliente Regular");
            Console.WriteLine("2. Registrar Cliente VIP");
            Console.WriteLine("3. Registrar Reserva");
            Console.WriteLine("4. Mostrar Detalles de Clientes");
            Console.WriteLine("5. Mostrar Detalles de Reservas");
            Console.WriteLine("6. Buscar Cliente por Nombre");
            Console.WriteLine("7. Buscar Reserva por Número");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            Console.Clear();

            switch (opcion)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Registrar Cliente Regular");
                        Console.Write("Ingrese el nombre del cliente: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el correo electrónico: ");
                        string correo = Console.ReadLine();
                        Console.Write("Ingrese el número de teléfono: ");
                        string telefono = Console.ReadLine();
                        ClienteRegular clienteRegular = new ClienteRegular(nombre, correo, telefono);
                        sistemaClientes.AgregarCliente(clienteRegular);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al registrar cliente regular: {ex.Message}");
                    }
                    break;

                case "2":
                    try
                    {
                        Console.WriteLine("Registrar Cliente VIP");
                        Console.Write("Ingrese el nombre del cliente: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el correo electrónico: ");
                        string correo = Console.ReadLine();
                        Console.Write("Ingrese el número de teléfono: ");
                        string telefono = Console.ReadLine();
                        Console.Write("Ingrese el porcentaje de descuento (ejemplo: 0.15 para 15%): ");
                        double descuento = double.Parse(Console.ReadLine());
                        ClienteVIP clienteVIP = new ClienteVIP(nombre, correo, telefono, descuento);
                        sistemaClientes.AgregarCliente(clienteVIP);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al registrar cliente VIP: {ex.Message}");
                    }
                    break;

                case "3":
                    try
                    {
                        Console.WriteLine("Registrar Reserva");
                        Console.Write("Ingrese el nombre del cliente para la reserva: ");
                        string nombreCliente = Console.ReadLine();
                        Cliente cliente = sistemaClientes.BuscarCliente(nombreCliente);
                        if (cliente != null)
                        {
                            Console.Write("Ingrese la fecha de la reserva (Año-Mes-Dia): ");
                            string fecha = Console.ReadLine();
                            Console.Write("Ingrese la hora de la reserva (Hora:Minuto): ");
                            string hora = Console.ReadLine();
                            Reserva reserva = new Reserva(0, fecha, hora, cliente);

                            bool agregarPlatos = true;
                            while (agregarPlatos)
                            {
                                Console.Write("Ingrese el nombre del plato: ");
                                string nombrePlato = Console.ReadLine();
                                Console.Write("Ingrese el precio del plato: ");
                                double precioPlato = double.Parse(Console.ReadLine());
                                Plato plato = new Plato(nombrePlato, precioPlato);
                                reserva.AgregarPlato(plato);

                                Console.Write("¿Desea agregar otro plato? (s/n): ");
                                agregarPlatos = Console.ReadLine().ToLower() == "s";
                            }

                            sistemaReservas.RegistrarReserva(reserva);
                        }
                        else
                        {
                            Console.WriteLine("Cliente no encontrado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al registrar la reserva: {ex.Message}");
                    }
                    break;

                case "4":
                    Console.WriteLine("Detalles de Clientes:");
                    sistemaClientes.MostrarClientes();
                    break;

                case "5":
                    Console.WriteLine("Detalles de Reservas:");
                    sistemaReservas.MostrarReservas();
                    break;

                case "6":
                    try
                    {
                        Console.WriteLine("Buscar Cliente por Nombre:");
                        Console.Write("Ingrese el nombre del cliente a buscar: ");
                        string nombreBuscar = Console.ReadLine();
                        Cliente clienteBuscado = sistemaClientes.BuscarCliente(nombreBuscar);
                        if (clienteBuscado != null)
                        {
                            clienteBuscado.MostrarDetalles();
                        }
                        else
                        {
                            Console.WriteLine("Cliente no encontrado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al buscar el cliente: {ex.Message}");
                    }
                    break;

                case "7":
                    try
                    {
                        Console.WriteLine("Buscar Reserva por Número:");
                        Console.Write("Ingrese el número de la reserva a buscar: ");
                        int numeroReserva = int.Parse(Console.ReadLine());
                        Reserva reservaBuscada = sistemaReservas.BuscarReserva(numeroReserva);
                        if (reservaBuscada != null)
                        {
                            reservaBuscada.MostrarDetalles();
                        }
                        else
                        {
                            Console.WriteLine("Reserva no encontrada.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al buscar la reserva: {ex.Message}");
                    }
                    break;

                case "8":
                    continuar = false;
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }
}