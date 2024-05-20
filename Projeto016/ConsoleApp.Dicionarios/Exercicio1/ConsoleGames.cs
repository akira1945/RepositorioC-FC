using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Dicionarios.Exercicio1
{
    public class ConsoleGames
    {
        public string NomeConsole { get; set; }

        public int Quantidade { get; set; }

        public ConsoleGames( string nomeConsole, int quantidade )
        {
            this.NomeConsole = nomeConsole;
            this.Quantidade = quantidade;
        }
    }

}      