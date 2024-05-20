using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.LinkedList.Classes
{
    public class EditorDeTexto
    {
        LinkedList<char> conteudo = new();

        LinkedListNode<char> cursor;

        
        public EditorDeTexto(string texto)
        {
            foreach (var item in texto)
            {
                conteudo.AddLast(item);
            }
            cursor = conteudo.First;
        }
        
        public void Inserir(char caractere)
        {
            conteudo.AddLast(caractere);
        }

        public void MoverCursorParaTras()
        {
            cursor = cursor.Previous;
        }

        public void MoverCursorParaFrente()
        {
            cursor = cursor.Next;
        }

        public void Exibir ()
        {

            foreach (var item in conteudo)
            {
                Console.WriteLine(item);
            }
            // while(cursor !=null){ faz a lista andar

            //     System.Console.WriteLine(cursor.Value);
            //     cursor= cursor.Next;
            // }

        }

        public void Deletar(char? caracter = null)
        {
            if(cursor != null)
            {
            var proximo = cursor.Next;
            conteudo.Remove(cursor);
            cursor = proximo; 
            }
        }
    }
}