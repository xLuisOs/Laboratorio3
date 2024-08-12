class program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Registarar Cliente ");
            Console.WriteLine("2. Regustrar Vehiculo ");
            Console.WriteLine("3. Registrar Pedido ");
            Console.WriteLine("4. Mostrar Detalles ");
            Console.WriteLine("5. Buscar ");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Ingrese una opcion");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }

            }catch (Exception ex)
            {

            }
            
        } while (opcion != 6);
    }
}