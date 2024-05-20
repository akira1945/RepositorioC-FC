using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(char nome, char departamento) : base(nome, departamento)
        {
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Eu sou desenvolvedor");
        }
    }
}