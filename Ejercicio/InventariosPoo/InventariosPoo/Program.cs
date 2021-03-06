using System;

namespace inventario
{
    class Program
    {        
        static void Main(string[] args)
        {
            string opcion = "";
            Inventario inventario = new Inventario();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("4 - Entrada de Ajuste de Inventario");
                Console.WriteLine("5 - Salida de Entrada de Inventario");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        inventario.listarProductos();
                        break;
                    case "2":
                        inventario.ingresoDeInventario();
                        break;  
                    case "3":
                        inventario.salidadeinventario();
                    break;
                    case "4":
                        inventario.EntradadeAjustedeinventario();
                    break;  
                    case "5":
                        inventario.salidadeAjsutedeinventario();
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