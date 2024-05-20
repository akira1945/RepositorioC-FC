using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.SortedSet.Classes{

    public class ComparadorDeTarefas : IComparer<Tarefas>

    {
        public int Compare(Tarefas? x, Tarefas? y)
        {
            return x.Prioridade.CompareTo(y.Prioridade);
        }
    }

}