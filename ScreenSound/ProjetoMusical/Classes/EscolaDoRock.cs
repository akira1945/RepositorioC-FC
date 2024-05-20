using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Classes
{
    public class EscolaDoRock
    {
        public string Titulo;

        public int AnoLancamento;

        public EscolaDoRock( string titulo, int ano)
        {
            this.Titulo = titulo;
            this.AnoLancamento = ano;
        }

        public EscolaDoRock()
        {
            
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine($"Título: {Titulo}");
            System.Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
        }
    
    }

}