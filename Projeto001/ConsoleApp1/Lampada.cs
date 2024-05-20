using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.obj
{
    public class Lampada
    {
        public bool Estado { get; set; }

        public int Intensidade { get; set; }


        
    public Lampada(bool estado, int intensidade)
    {
        Estado = estado;
        Intensidade = intensidade;
               
    }

    public Lampada()
    {
        
    }

    public void LigarDesligar ()
        {
            if (this.Estado == true){
                this.Estado = false;
                Console.WriteLine("Desligado");
            }
            else{
                this.Estado = true;
                Console.WriteLine("Ligado");
            }
        }

    
    public void AjusteIntensidade ( int novaIntensidade )
        {
            if (this.Estado == true){
                this.Estado = false;
                Console.WriteLine("Desligado");
            }
            else{
                this.Estado = true;
                Console.WriteLine("Ligado");
            }
        }


    }


}