using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.HashSet.Exercicio
{
    public class SistemaDeDeteccaoDeFraude
    {
        public HashSet<string> Transacao;

        public SistemaDeDeteccaoDeFraude()
        {
            
            Transacao = new HashSet<string>();

        }

        public bool AdicionarTransacao(string numTransacao)
        {
            if(!Transacao.Add(numTransacao))
            {
                System.Console.WriteLine($"Possível fraude, numero transação em duplicidade : {numTransacao}");
                return false;
            }
            System.Console.WriteLine($"Transação {numTransacao} adicionada com sucesso");
            return true;
        }
    }
}