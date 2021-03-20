using System;
public class pezglobo: acuaticos // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Pelaje { get; set; }

    public pezglobo() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public pezglobo(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void gritar() // <- Abstraccion
    {
        Console.WriteLine("no se escuha su sonido");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("pequeno");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
          Console.WriteLine("inflarse");
    }
}