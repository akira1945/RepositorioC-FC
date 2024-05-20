using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Funcionario
    {
         private char Nome;

         private char Departamento;
    
    public char nome { get{ return Nome;} set{Nome = value;} }
    public char departamento {get{ return Departamento; } set{Departamento = value;}}

    public Funcionario(char nome, char departamento)
    {
        this.Nome = nome;
        this.Departamento = departamento;
    }

    public abstract void Trabalhar();

    
    }

    
}