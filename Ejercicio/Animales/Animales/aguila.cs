using System;
public class Aguila: Aves // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Plumaje { get; set; }

    public Aguila() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public Aguila(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void gritar() // <- Abstraccion
    {
        Console.WriteLine("juiiiiiiiiiiiiiiiii");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Aguila blanco con negro");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
          Console.WriteLine("Cazador Aereo y efectivo volando alto");
    }
}