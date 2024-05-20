using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMusical.Exercicio_1
{
    public class ContasBancarias
    {
        public string NomeTitular { get; set; }
        public int Numero { get; set; }

        public bool Indicador { get; set;}

        public double Saldo { get; set;}

        public string Senha { get; set; }   

        public string verificarSaldo { get; set; }

        public ContasBancarias(string nome,int numero, bool indicador, double saldo, string senha, string verificar)
        {
            this.NomeTitular = nome;
            this.Numero = numero;
            this.Indicador = indicador;
            this.Saldo = saldo; 
            this.Senha = senha;
            this.verificarSaldo = verificar;
        }

        public ContasBancarias()
        {
            
        }

        string digiteSuaSenha;
        string senhaDigita;
        public void InsiraSuaSenha()
        {
            Console.WriteLine($"Deseja validar sua conta : [S] [N]");
            string digiteSuaOpcao = Console.ReadLine()!;
            if(digiteSuaOpcao =="S")
            {
                
                Console.WriteLine($"Digite Sua Senha: ");
                string digiteSuaSenha = Console.ReadLine()!;
                Console.WriteLine(senhaDigita = digiteSuaSenha);
            }

        }
        public void ExibirInformacoesContas()
        {
            if (senhaDigita == Senha){
                 Console.WriteLine($"\nNome do Títular: {NomeTitular} ");
                 Console.WriteLine($"Numero da Conta: {Numero}");
                if(Indicador)
                {
                    Console.WriteLine($"Cliente ativo do banco");
                }else
                {
                    Console.WriteLine($"Abra sua conta.");
                }
                if(verificarSaldo == "S")
                {
                        if(Saldo == 0)
                        {
                            Console.WriteLine($"Faça seu primeiro deposito, saldo é {Saldo}");
                            Thread.Sleep(5000);
                        }else
                        {
                            Console.WriteLine($"\nSaldo = {Saldo}");
                            Thread.Sleep(5000);
                        }
                }else
                {
                    Console.WriteLine("Pressione qualquer tecla para sair!!!");
                    Console.ReadKey();
                }
            }else
            {
                Console.WriteLine("Senha incorreta, por favor, digite novamente sua senha!!!");
                Thread.Sleep(5000);
                Console.Clear();
                InsiraSuaSenha();
                ExibirInformacoesContas();
            }
           
            Console.WriteLine("Consulta encerrada, volte sempre!!!");
            Thread.Sleep(5000);
            Console.Clear();
        }

    }

}
