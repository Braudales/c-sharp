using System;
using System.Collections.Generic;

public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        
        Producto p1 = new Producto(1, "Santa Marta", 50  );
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Aldea del carmen", 100);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "De sula",60 );
        ListadeProductos.Add(p3);


    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Rocio", "9480-0358");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Catheryn", "9674-2122");
        ListadeClientes.Add(c2);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Toño", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Carlos", "V002");
        ListadeVendedores.Add(v2);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Colonias");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Colaboradores");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Transportistas");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.WriteLine("Creando Viaje");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del Colaborador: ");
        Console.WriteLine("1. Rocio: ");
        Console.WriteLine("2. Catheryn: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Colaborador no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Colaborador: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del Transportista: ");
        Console.WriteLine("1. Toño: ");
        Console.WriteLine("2. Carlos ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Transportista no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Transportista: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            
            Console.WriteLine("Ingrese las colonias: ");
            Console.WriteLine("1. Santa Martha: ");
            Console.WriteLine("2. Aldea del Carmen: ");
            Console.WriteLine("3. De sula: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("colonia no encontrada");
                Console.ReadLine();
            } else {
                Console.WriteLine("Colonia agregado: " + producto.Descripcion + " con precio de : " + producto.Precio );
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea cregistrar otro viaje? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("El total del viaje: " + nuevaOrden.Total);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Viajes");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha | Total ");
        Console.WriteLine("Colaborador | Transportista");
        Console.WriteLine("======================");
        Console.WriteLine("");
          

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.Total);
            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);

            foreach (var detalle in orden.ListaOrdenDetalle)
            {
              
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
                 
                           }
                
            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}