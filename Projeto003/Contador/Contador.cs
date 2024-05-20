using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contador
{
    public class Contador
    {
        public int Valor; 
        
        public bool estaAtivo;


    // Construtor da calsse Contador

    public Contador( int valor, bool estaAtivo)
    {
        this.Valor = valor;
        this.estaAtivo = estaAtivo;        
    }     
   
   // Método para incrmentar o valor do contador

   public void Incrementar()
   {
    Valor++; // Aumenta o valor do contador em um
    System.Console.WriteLine($"Valor incrementado : {Valor}");
   }

    public void Decrementarr()
   {
    Valor--; // Diminui o valor do contador em um
    System.Console.WriteLine($"Valor incrementado : {Valor}");
   }
   
   
    }
}
