using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesGenericas.Exercicio_01
{
    public abstract class ProdutoBase
    {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public DateTime Data { get; set; }


        public ProdutoBase(int id, string nome, double preco, DateTime data)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;  
            this.Data = data;          
        }



    }
}