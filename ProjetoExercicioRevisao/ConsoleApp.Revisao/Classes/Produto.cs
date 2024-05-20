using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Revisao.Classes
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string  NomeProduto { get; set; }

        public string  Categoria { get; set; }

        public double  PrecoProduo { get; set; }

        public Produto()
        {
            
        }
    }
}