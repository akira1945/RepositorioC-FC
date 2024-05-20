using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Pessoa
    {
        private int idade;

        public int Idade //Dentro dos Getteres RETURN, Setters temos que utilizar o comando VALUE(Referenciando a propriedade privada).
        {
            get { return idade; }
            set
            {
                if (value < 0)
                { idade = 0; }
                else { idade = value; }
            }
        }

        public Pessoa( int idadeInicial)
        {
            Idade = idadeInicial;
        }

        public void Aniversario(int novaIdade)
        {
            idade++ ; //Esta fazendo uma ação - tem que ser void.
        }
    }
}