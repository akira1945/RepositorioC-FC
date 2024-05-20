using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Termometro
    {
        public double Temperatura;

       // Construtor
       public Termometro(double temperatura)
       {
         Temperatura = 0.0;
       }
       
       // Metodo
       public void AjustarTemperatura( double NovaTemperatura)
       {
        this.Temperatura = NovaTemperatura;
        System.Console.WriteLine($"Temperatura ajustada para {Temperatura} graus.");
       }

       public string MostrarTemperatura()
       {
        return ($"Temperatura atual : {Temperatura}");        
       }


    }
}