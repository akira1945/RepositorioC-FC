using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.SortedSet.Classes
{
    public class GestorDeTarefas
    {
        SortedSet<Tarefas> tarefa ;


        public GestorDeTarefas(SortedSet<Tarefas> tarefa)
        {
            this.tarefa = tarefa;
        }

        public void AdicionarTarefa(string descricao, int prioridade)
        {
            
        }
    }
}