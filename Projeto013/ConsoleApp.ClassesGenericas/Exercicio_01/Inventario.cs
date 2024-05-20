using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesGenericas.Exercicio_01
{
    public class Inventario <T>
    {
        private List<T> Itens{ get; set; } = new List<T>();

// Construtor

        public Inventario(List<T> itens)
        {
            Itens = itens;
        }

// Metodos

        public void Adicionar (T obj)
        {
             Itens.Add(obj);
        }

        public void Remover (T obj)
        {
            Itens.Remove(obj);
        }

        public List<T> ListarItens ()
        {
            return Itens;   
        }
    }
}