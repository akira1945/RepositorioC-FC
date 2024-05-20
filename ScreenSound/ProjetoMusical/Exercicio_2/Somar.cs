using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProjetoMusical.Exercicio_2
{
    public class Somar
    {
        public int Resultado { get; set; }

        public int valor1 { get; set; }
        public int valor2 { get; set; }

        public Somar()
        {
            
        }
        
        public void SomarValores()
        {
            Resultado = valor1 + valor2;
            Console.WriteLine(Resultado);
        }  
        

    }
}