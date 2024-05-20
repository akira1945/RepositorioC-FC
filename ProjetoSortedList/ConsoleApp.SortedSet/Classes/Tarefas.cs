using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.SortedSet.Classes
{
    public class Tarefas
    {
        public string  Descricao { get; set; }

        public int Prioridade { get; set; }

        public Tarefas(string descricao, int prioridade)
        {
            this.Descricao = descricao;
            this.Prioridade = prioridade;            
        }
    }
}