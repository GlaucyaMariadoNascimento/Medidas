using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
 
          double metros, metrosparacm, metrosparakm;

          Console.Write("Entre com a medida em metros: ");
          
          metros = Convert.ToDouble(Console.ReadLine());
        
          Console.WriteLine("\n----Equivalencia----");

          metrosparacm = metros*100;

          metrosparakm = metros/1000;

          Console.WriteLine($"{metrosparacm} cm");

          Console.WriteLine($"{metros} m");

          Console.WriteLine($"{metrosparakm} km");
            
        }
    }
}
