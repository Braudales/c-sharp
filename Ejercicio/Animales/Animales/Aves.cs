using System;

public abstract class Aves: Animal
{
    public int Patas { get; set; }
      public int alas { get; set; }
    public void volar()
    {
        Console.WriteLine("Volando...");
    }
}