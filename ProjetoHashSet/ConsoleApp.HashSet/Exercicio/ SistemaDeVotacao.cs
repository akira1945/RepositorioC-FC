using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.HashSet.Exercicio
{
    public class  SistemaDeVotacao
    {

        public Dictionary<string, HashSet<string>> votoCategorizado;


        public  SistemaDeVotacao()
        {
            votoCategorizado = new Dictionary<string, HashSet<string>>();
        }  

      public bool AdicionarVoto(string categoria, string numVoto)
      {
        
        if(!votoCategorizado.ContainsKey(categoria))
        {   
                var novaCategoria = votoCategorizado[categoria];
                if(!votoCategorizado.ContainsKey(numVoto))
                {
                votoCategorizado[categoria].Add(numVoto);
                }
            Console.Write($"Voto de numero {numVoto}, com categoria {categoria}, invalidado por duplicidade");
            return false;
        }
        else
        {
            votoCategorizado[categoria] = [numVoto];
        }
        Console.WriteLine($"Voto {numVoto}, em categoria {categoria} contabilizado.");
        return true;

      }

    }
}