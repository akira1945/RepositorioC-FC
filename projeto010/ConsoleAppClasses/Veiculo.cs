using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppClasses
{

       public class Veiculo
    {
        private string Marca;

        private string Modelo;

        private int Ano;

        public string marca{ get{ return Marca; } set{ Marca = value; } }
        public string modelo{ get{ return Modelo; } set{ Modelo = value; } }
        public int ano{ get{ return Ano; } set{ Ano = value; } }    

        public Veiculo(string marca, string modelo, int ano)
        {
            this.Marca  = marca;
            this.Modelo = modelo;
            this.Ano    = ano;
        }
        

        public string NovoMarca(string marcaNova){
        // Console.WriteLine($"Modelo carro {marca}");
        Marca = marcaNova;
        return marcaNova;
        }
        public void NovoModelo(){
        Console.WriteLine($"Modelo carro {modelo}");
        }

        public void AnoFabricado(){
        Console.WriteLine($"Modelo carro {ano}");
        }
        


    }
}