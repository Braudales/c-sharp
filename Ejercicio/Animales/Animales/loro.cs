using System;
public class loro: Aves // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Plumaje { get; set; }

    public loro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public loro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void hablar() // <- Abstraccion
    {
        Console.WriteLine("hola soy LORO LORIN y tu");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("pequeno y color verde");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
          Console.WriteLine("hablar");
    }
}