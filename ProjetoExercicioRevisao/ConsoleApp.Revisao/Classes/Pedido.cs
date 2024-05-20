using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Revisao.Classes
{
    public class Pedido
    {

        public string Item { get; set; }

        public int Quantidade { get; set; } 

        public double Preco { get; set; }

        public string Preparando {get; set; }

        public Pedido(string item, int quantidade, double preco)
        {
            this.Item = item;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        public double CalcularTotal()
        {
           
            return Quantidade * Preco;
           
        }

        public void Preparar()
        {
            if(Preparando == Preparacao.InciandoPrato)
            {
                Console.WriteLine($"Pedido chegou a cozinha,esta sendo {Preparacao.InciandoPrato}");
            }
            else if (Preparando == Preparacao.PratoEmpreparacao)
            {
                System.Console.WriteLine($"Pedido chegou a cozinha, esta sendo {Preparacao.InciandoPrato}");
            }
            else if (Preparando == Preparacao.PratoFinalizado)
            {
                System.Console.WriteLine($"Pedido chegou a cozinha, esta sendo {Preparacao.PratoFinalizado}");
            }
            else if (Preparando == Preparacao.PratoEmpreparacao)
            {
                System.Console.WriteLine($"Preparação finalizada, {Preparacao.PreparacaoFinalizada}");
            }

        }

    }
}