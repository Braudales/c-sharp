using System;
public class Mono: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Pelaje { get; set; }

    public Mono() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Mono(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void gritar() // <- Abstraccion
    {
        Console.WriteLine("hua a a a hua a a a");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es mono blanco con negro");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
          Console.WriteLine("Es mono inteligenete");
    }
}