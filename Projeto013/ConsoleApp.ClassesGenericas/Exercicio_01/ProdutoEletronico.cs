using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesGenericas.Exercicio_01
{
    public class ProdutoEletronico : ProdutoBase
    {

        public string EspecificacaoTec { get; set; }

    
    //Construtor

        public ProdutoEletronico(int id, string nome, double preco,string especificacaoTec, DateTime data ) : base(id, nome, preco, data)
        {

            this.EspecificacaoTec = especificacaoTec;

        }

     //Metodos

        
    
    }

}