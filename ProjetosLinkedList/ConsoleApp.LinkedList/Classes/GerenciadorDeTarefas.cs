using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.LinkedList.Classes
{
    public class GerenciadorDeTarefas
    {
        LinkedList<string> tarefas ;
        

        public GerenciadorDeTarefas()
        {
            tarefas = new LinkedList<string>();
        }


        public void AdicionarTarefa(string item)
        {
            tarefas.AddLast(item);
        }


        public void MostrarTarefas()
        {
            foreach (string item in tarefas)
            {
                Console.WriteLine(item);
            }
        }


        public void CompletarTarefa()
        {
            if(tarefas !=null)
            {
             tarefas.RemoveFirst();                          
            }
        
        }

    }
}