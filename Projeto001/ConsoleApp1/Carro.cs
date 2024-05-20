using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Carro
    {
        public string Modelo {get; set;}

        public string Cor {get; set;}

        public int Ano { get; set; }

        public string Placa { get; set; }

        public double VelocidadeAtual { get; set; }


    }

    
        public Carro(string modelo, int ano, string placa, double velocidadeatual, cor string ) 
        {

            Modelo = modelo;
            Ano = ano;
            Placa = placa;
            VelocidadeAtual = velocidadeatual;
            Cor = cor;

        }

        public Carro()
        {
            
        }

        public void Acelerar (double incremento, int outraCoisa )
        {
            this.VelocidadeAtual += incremento;
            Carro.writeline($"velocidade do carro subiu para {this.VelocidadeAtual}")
        }

        public void Frear (double decremento)
        {
            this.VelocidadeAtual += incremento;
            Carro.writeline($"velocidade do carro diminuiu para {this.VelocidadeAtual}")
        }

        public string Ligar ()
        {
            //ConsoleApp1.writeline($" O carro esta ligado {this.VelocidadeAtual}")
           return "O carro esta ligado";
        }



}