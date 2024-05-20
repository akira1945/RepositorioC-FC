/*
#region  fila

//Para adicionar

Stack<string> acoes = new Stack<string>();
acoes.Push("Adicionar livros");
acoes.Push("Alinhar livros");
acoes.Push("Limpar livros");
acoes.Push("Adicionar Linha de Codigo");

//Para excluir não pode simplesmente limpar

while(acoes.Count >0)
{
   
   Console.WriteLine($" Ação :{acoes.Pop()} da pilha limpa!");

}

acoes.Clear();

#endregion fila

#region vamosPraticar

Stack<string> historico = new();
Dictionary<string, List<string>> biblioteca =[];

AdicionarLivrosLidos.Add("Ficção", new List<string>(){"Star Wars - Guerras Clonicas", "MortalKombat", "Milha Verde"});
AdicionarLivrosLidos.Add("Ação", new List<string>(){"Matadores de Aluguel", "Inimigo Intimo", "O peste"});
AdicionarLivrosLidos.Add("Historia", new List<string>(){"Sacahhar", "A morte branca", "Herois do dia D"});





#endregion vamosPraticar
*/

