public class Producto
{
    public int Codigo { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }
    public double Impuesto { get; set; }
    
    public double Preciofinal { get; set; }
   
    public Producto(int codigo, string descripcion, double precio, double impuesto,double preciofinal)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Precio = precio;
        Impuesto = impuesto;
        Preciofinal=preciofinal;
    
    }
}