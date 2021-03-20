using System;

public abstract class acuaticos: Animal
{
    public int Patas { get; set; }
      public int alas { get; set; }
       public int aletas { get; set; }

    public void volar()
    {
        Console.WriteLine("Nadando...");
    }
}