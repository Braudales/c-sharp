using System;

namespace _10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Transporte");
                 Console.WriteLine("      GAC");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Colonias");
                Console.WriteLine("2 - Crear Viaje");
                Console.WriteLine("3 - Lista de Colaboradores");
                Console.WriteLine("4 - Lista de Transportistas");
                Console.WriteLine("5 - Lista de Viajes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearOrden();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarVendedores();
                        break;      
                    case "5":
                        datos.ListarOrdenes();
                        break;                                      
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}