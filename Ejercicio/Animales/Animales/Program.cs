using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de animales");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Animales Mamiferos");
                Console.WriteLine("2 - Animales Aereos");
                Console.WriteLine("3 - Animales Acuaticos");
                Console.WriteLine("0 - Salir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: 
                    int opc;
                    Console.Clear();
                        Console.WriteLine("Ha Elegido usted Animales mamifero");
                        Console.WriteLine("Selecciona el animal a conocer ......");
                        Console.WriteLine("1 - perro ");
                        Console.WriteLine("2 - gato  ");
                        Console.WriteLine("3 - Mono ");
                        opc = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opc)
                        {
                            case 1:
                            
                            Utilidades.EnviarCorreo();

                              Perro p = new Perro();
                            p.Nombre = "Firulais";
                            p.Patas = 4;
                             p.EsDomestico = true;
                             p.Comer();
                             p.Caminar();
                             p.Ladrar();
                             p.Tamano();

                             Console.WriteLine(p.Nombre);
                             Console.WriteLine(p.Patas);
                      
        
                            break;
                            case 2:
                              Gato g = new Gato();
                              g.Nombre = "Garfield";
                              g.Patas = 4;
                              g.Pelaje = "Peludo";
                              g.Comer();
                              g.Caminar();
                              g.Maullar();
                            break;
                            case 3:
                              Mono m = new Mono();
                              m.Nombre = "Litle Monkey";
                              m.Patas= 4 ;
                              m.Pelaje = "Peludo";
                              m.gritar();
                              m.Comer();
                              m.Caminar();
                              m.Tamano();
                              
                            Console.WriteLine(m.Nombre);
                            Console.WriteLine(m.Patas);
                      
                              
                        
                            break;
                            default:
                            break;
                           
                        }
                       
                        Console.ReadKey();
                       break;
                    case 2:
                              int opci;
                    Console.Clear();
                        Console.WriteLine("Ha Elegido usted Animales Aereos");
                        Console.WriteLine("Selecciona el animal a conocer....... ");
                        Console.WriteLine("1 - Aguila ");
                        Console.WriteLine("2 - Loro  ");
                        Console.WriteLine("3 - Pendiente ");
                        opci = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opci)
                        {
                            case 1:
                            
                            Utilidades.EnviarCorreo();
                            Aguila a = new Aguila();
                             a.Nombre = "Motagua";
                             a.Patas = 2;
                             a.alas =2;
                             a.EsDomestico = false;
                             a.Comer();
                             a.volar();
                             a.Tamano();
                             a.Plumaje= " Liso";
                             
                             Console.WriteLine(a.Nombre);
                             Console.WriteLine(a.Patas);
                             Console.WriteLine(a.alas);
                             
                              
                            break;
                            case 2:
                               loro l = new loro();
                             l.Nombre = "Juan";
                             l.Patas = 2;
                             l.alas =2;
                             l.EsDomestico = true;
                             l.Comer();
                             l.volar();
                             l.Tamano();
                             l.Plumaje= " Liso";
                             l.hablar();
                             
                             Console.WriteLine(l.Nombre);
                             Console.WriteLine(l.Patas);
                             Console.WriteLine(l.alas);
                            break;
                            case 3:
                              
                        
                        
                            break;
                            default:
                            break;
                           
                        }
                       
                        Console.ReadKey();
                       break;
                    
                     case 3:
                        int opcio;
                    Console.Clear();
                        Console.WriteLine("Ha Elegido usted Animales acuaticos");
                        Console.WriteLine("Selecciona el animal a conocer ......");
                        Console.WriteLine("1 - Pez Globo ");
                        opcio = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opcio)
                        {
                            case 1:
                            
                            Utilidades.EnviarCorreo();

                              pezglobo p = new pezglobo();
                              p.Nombre = "Globito";
                              p.aletas = 2;
                              p.EsDomestico = true;
                              p.Comer();
                              p.Tamano();
                              p.gritar();
                              

                             Console.WriteLine(p.Nombre);
                             Console.WriteLine(p.aletas);
                      
        
                            break;
                            default:
                            break;
                           
                        }
                       
                        Console.ReadKey();
                        break;
                    
                    default:
                    break;
                }

                if (op == 0) {
                    break;
                }
            }  
          
        }
    }
}
