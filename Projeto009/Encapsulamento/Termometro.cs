using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Termometro
    {
        private double temperaturaCelsius;

             

        public Termometro(double temperaturaX)
        {
            temperaturaCelsius = temperaturaX;
            
        }

        public void ajustarTemperatura( double temperatura )
        {
            if (temperaturaCelsius = temperaturaX)
            Console.WriteLine($"Temperatura aceitavel {temperaturaCelsius}");
        }
    }




    }
}