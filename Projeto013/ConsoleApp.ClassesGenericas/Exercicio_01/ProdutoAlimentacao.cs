using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesGenericas.Exercicio_01
{
    public class ProdutoAlimentacao : ProdutoBase


    {
        public double PesoGramas { get; set; }
    
    
        public ProdutoAlimentacao(int id, string nome, double preco, DateTime data, double Peso ) : base(id, nome, preco, data)
        {
            this.PesoGramas = Peso;
        }

        
    }
}