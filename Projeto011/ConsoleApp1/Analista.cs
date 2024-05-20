using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Analista : Funcionario
    {
        public Analista(char nome, char departamento) : base(nome, departamento)
        {
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Meu novo cargo é Analista de Suporte a Sistemas");
        }
    }
}