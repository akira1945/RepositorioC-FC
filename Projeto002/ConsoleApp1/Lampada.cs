using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lampada
    {
        public bool Estado { get; set; }

        public int Intensidade { get; set; }


        public Lampada( bool estado, int intensidade )
        {
            Estado = estado;
            Intensidade = intensidade;
        }

        public Lampada()
        {
            
        }

        public int AjusteIntensidade (){

            switch (Intensidade)
            {
                case > 10:
                case < 100:
                    {
                        int intensidade = Intensidade;
                        return intensidade;
                        break;
                    }

                default:
                    return 0;
            }

        }

        public string LigarDesligar(){

            if (Estado){
                  return ($"Lampada Ligada com intensidade {Intensidade}");
            }else return ("Lampada desligada com intensidade 0 ");

        }
        

    }

}