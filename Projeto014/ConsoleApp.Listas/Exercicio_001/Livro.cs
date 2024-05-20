using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Listas.Exercicio_001
{
    public class Livro
{
        public Livro()
        {
        }

        public Livro(string titulo, int numeroDePaginas) 
        {
            this.Titulo = titulo;
            this.NumeroDePaginas = numeroDePaginas;
   
        }
public string Titulo { get; set; }
public string Autor { get; set; }
public int NumeroDePaginas { get; set; }
public string Categoria { get; set; }
}
}