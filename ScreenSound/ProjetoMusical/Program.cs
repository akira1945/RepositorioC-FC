using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using ProjetoMusical.Classes;
using ProjetoMusical.Exercicio_1;
using ProjetoMusical.Exercicio_2;

// Screen Sound
// "" Escrever um texto sempre com aspas duplas
// toda espreção tem que ser terminada com ;
// Variavel utilizar padrão camelCase;
//encontrar o tamanho de uma cadeia de caracteres usando Length. Length 
// Contains retorna um valor booliano, True ou False. Serve para realizar pesquisas no codigo.

// + para adição.Outras operações matemáticas comuns para inteiros incluem: - para subtração * para multiplicação / para divisão
// % operador restante.
// @ deixar a string igual a forma que foi construida.
// \n dentro do texto console.writeline da um espaço da linha de cima.

#region ScreenSound_Classes

Musica musica1 = new Musica();
musica1.NomeMusica = "Madalenna Salerosa";
musica1.Artista = "Trio Los Panchos";
musica1.Duracao = 320;
musica1.disponivel = true;
//musica1.EscreverDisponivel(true);

Musica musica2 = new Musica();
musica2.NomeMusica = "Haven";
musica2.Artista = "Bryan Adams";
musica2.Duracao = 500;
musica2.disponivel = false;
//musica2.EscreverDisponivel(false);

musica2.ExibirNmArtMusica();
musica1.ExibirNmArtMusica();

//musica1.ExibirFicaTecnica();
//musica2.ExibirFicaTecnica();

EscolaDoRock filme1 = new EscolaDoRock();
filme1.Titulo = "Escola do Rock";
filme1.AnoLancamento = 2003;

//filme1.ExibirInformacoes();



#endregion ScreenSound_Classes

#region exercicio1_CLASSE

ContasBancarias conta0 = new ContasBancarias();
conta0.NomeTitular = "Astolfo Pires";
conta0.Numero = 1;
conta0.Indicador = true;
conta0.Saldo = 35000.00;

// Console.WriteLine($"Nome:{conta0.NomeTitular}");
// Console.WriteLine($"Numero:{conta0.Numero}");
// Console.WriteLine($"Saldo:{conta0.Saldo}");
// if(conta0.Indicador){
// Console.WriteLine($"Cliente ativo do banco");
// }else{
//     Console.WriteLine($"Abra sua conta.");
// }

ContasBancarias conta1 = new ContasBancarias();
conta1.NomeTitular = "Evandro Guedes";
conta1.Numero = 2;
conta1.Indicador = true;
conta1.Saldo = 3435000.00;
conta1.Senha = "Deus123";
conta1.verificarSaldo = "S";

//conta1.InsiraSuaSenha();
//conta1.ExibirInformacoesContas();

#endregion exercicio1_CLASSE

#region exercicio2_CLASSE
//Expressões lambdas

List<int> numeros = new List<int>();
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);
numeros.Add(6);
numeros.Add(7);
numeros.Add(8);
numeros.Add(9);
numeros.Add(10);
numeros.Add(11);
numeros.Add(12);
numeros.Add(13);
numeros.Add(14);
List<int> numerosPares = numeros.FindAll(BuscarNumerosPares);

bool BuscarNumerosPares(int numero)
{
    return numero % 2 == 0;
}

// foreach (int numero in numerosPares)
// {
//     Console.WriteLine($"{numero},");
// }

List<int> numeros1 = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14};
List<int> numerosPares2 = numeros1.FindAll(numeros1 => numeros1 % 2 == 0);
//numerosPares2.ForEach(numeros1 => Console.Write($"{numeros1},"));


List<int> impares = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
List<int> numerosImpares = impares.FindAll(impares=>impares % 3 == 0);
//numerosImpares.ForEach(impares=>Console.Write($"\n{impares},"));

Filmes matrix = new Filmes();
matrix.Titulo = "Matrix";
matrix.Orcamento = 63;

//Console.WriteLine($"Nome do Filme {matrix.Titulo} com orçamento de : {matrix.Orcamento}");

Somar somar= new Somar();
somar.valor1 = 500;
somar.valor2 = 700;
somar.SomarValores();

#endregion exercicio2_CLASSE

#region ScreenSound

String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("SlipKnot", new List<int>(){8,7,6,4,5,3,2,1});
bandasRegistradas.Add("Metallica", new List<int>(){10,10,10,10,10,10,10,1});
bandasRegistradas.Add("The Rollingans", new List<int>(){10,10,9,8,4,10,10});
bandasRegistradas.Add("PinkFloyd",new List<int>(){8,7,6,4});

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
      Console.WriteLine();
      Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirOpcoesDoMenu()
{
    // Opções do programa
    //Console.WriteLine();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair.");

    //Capturar a opção digitada.

    Console.Write("\nDigite sua Opção: ");// não pula uma linha.
    string opcaoEscolhida         = Console.ReadLine()!;// Permite escrever na linha. A esclamação não permite que a resposta seja null.
    int    opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);// Conver string em numeral.
    
    //Informa ação da opção escolhida.
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: NotaDaAvalicaoPublico();
            break;
        case -1: Console.WriteLine("As ta la vista Baby !!!!!");
            break;
        default: Console.WriteLine("Opção Invalida!");
            break;
    }

 }  

 void RegistrarBanda()
 {
    Console.Clear();
    // Console.WriteLine("********************");
    // Console.WriteLine("Registros de bandas");
    // Console.WriteLine("********************\n");
    ExibirTituloDaOpcao(titulo: "Registros de bandas");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"Banda {nomeDaBanda} registrada com sucesso!!!");
    Thread.Sleep(2000);//faz o programa esperar um tempo(milesegundo)
    Console.Clear();
    ExibirOpcoesDoMenu();
 };

void MostrarBandasRegistradas()
{
    Console.Clear();
    // Console.WriteLine("*************************************");
    // Console.WriteLine("Exibindo todas as bandas registradas:");
    // Console.WriteLine("*************************************\n");
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas:");
    // for (int i = 0; i< listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // };
    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda : {banda}");
    };
    Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal!!!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
};

void AvaliarUmaBanda()
{
    //digite a banda a ser avaliada
    //se a banda existir no dicionario, atribuir uma nota
    //se não, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao(titulo: "Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\n nota {nota} foi registrada com sucesso para banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!!! ");
        Console.WriteLine("Digite uma tecla para retornar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

};

void NotaDaAvalicaoPublico()
{
    Console.Clear();
    ExibirTituloDaOpcao(titulo: "Media das notas de sua banda favorita");
    Console.Write("Digite o nome da banda que você quer ver a media: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {   
            List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nNota media da banda {nomeDaBanda} foi :{notasDaBanda.Average()}");
            Thread.Sleep(4000);
            Console.WriteLine("\nDigite qualquer tecla para retornar ao menu anterior.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
 
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!!! ");
        Console.WriteLine("Digite uma tecla para retornar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos =string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + '\n');
};


ExibirOpcoesDoMenu();

#endregion ScreenSound

#region Exercicios_aulas_1_2

// Exercicio aula 2
//1
int notaMedia = 5;
if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
};
//2
void menuLinguagensDeProgramacao()
{
    Console.WriteLine("\nDigite 1 para Java");
    Console.WriteLine("Digite 2 para C#");
    Console.WriteLine("Digite 3 para JavaScript");
    Console.WriteLine("Digite 4 para outra linguagem!");

    Console.Write("\nDigite sua opção: ");
    string opcaoDeLinguagem = Console.ReadLine()!;
    int opcaoDeLinguagemNumerica = int.Parse(opcaoDeLinguagem);

    switch (opcaoDeLinguagemNumerica)
    {
        case 1: Console.WriteLine($"Você escolheu a opção {opcaoDeLinguagem}");
            break;
        case 2: Console.WriteLine($"Você escolheu a opção {opcaoDeLinguagem}");
            break;
        case 3: Console.WriteLine($"Você escolheu a opção {opcaoDeLinguagem}");
            break;
        case 4: Console.WriteLine($"Você escolheu a opção {opcaoDeLinguagem}");
            break;
        default: Console.WriteLine($"Por favor, digite uma opção valida");
            break;
    }

}

menuLinguagensDeProgramacao();


Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }

} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");


// Interpolação de variaveis

        string helloMundo = "    Hello Mundo!!!!!    ";
        string meuFilho = "Daniel  ";
        string minhaFilha = "Giovanna   ";
        string minhaEsopsa = "   Valmira";
        string sentimento = "Amo vocês   ";

Console.WriteLine($"{helloMundo.Trim()} Meu {meuFilho.Trim()} ,Minha {minhaFilha.Trim()} ,Minha querida {minhaEsopsa.Trim()}, quero que saibam, {sentimento.Trim()} !!!!");
Console.WriteLine($"{helloMundo} Meu tamanho {helloMundo.Length} Caracteres ");// Mostra o tamanho da string ocupando a variável.

// utilização do TRIM

string nomeComEspaco = "   Olá Mundo!!!!!    ";
Console.WriteLine($"{nomeComEspaco}");

string nomeComEspacoTrimInicio = nomeComEspaco.TrimStart();
Console.WriteLine($"{nomeComEspacoTrimInicio}");

string nomeComEspacoTrimFinal = nomeComEspaco.TrimEnd();
Console.WriteLine(nomeComEspacoTrimFinal);

string nomeComEspacoTrim = nomeComEspaco.Trim();
Console.WriteLine(nomeComEspacoTrim);

// utilização do REPLACE,UPPER e LOWER

string vitoriaNaEuropa = "Alemanha se rendeu !!!!";
Console.WriteLine(vitoriaNaEuropa);
vitoriaNaEuropa = vitoriaNaEuropa.Replace("Alemanha", "Perdedor");
Console.WriteLine(vitoriaNaEuropa);

Console.WriteLine(vitoriaNaEuropa.ToLower());
Console.WriteLine(vitoriaNaEuropa.ToUpper());

// utilização do CONTAINS, STARWITH e ENDWITH

string historiDoMundo = "Um homem, uma vida cheia de emoção, no entanto, longe de quem ama";
Console.WriteLine(historiDoMundo.Contains("Terra"));
Console.WriteLine(historiDoMundo.Contains("ama"));

Console.WriteLine(historiDoMundo.StartsWith("Terra"));
Console.WriteLine(historiDoMundo.EndsWith("Terra"));
Console.WriteLine(historiDoMundo.StartsWith("ama"));
Console.WriteLine(historiDoMundo.EndsWith("ama"));

// Trabalhando com numerais INT

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int d = c - a;
Console.WriteLine(d);

int e = d * b;
Console.WriteLine(e);

int f = e / d;
Console.WriteLine(f);

int H = 7;
int I = 4;
int J = 3;
int L = (H + I) / J;
int M = (H + I) % J;//Operador relacional restante (%)
Console.WriteLine($"Cociente Truncado : {L}");
Console.WriteLine($"Operador Restante : {M}");

int maxInt = int.MaxValue;
int minInt = int.MinValue;
Console.WriteLine($"The range of integers is {minInt} to {maxInt}");

int what = maxInt + 3;
Console.WriteLine($"An example of overflow: {what}");

// utilizando o tipo DOUBLE e DECIMAL

double n = 5;
double o = 4;
double p = 2;
double q = (n + o) / p;
Console.WriteLine(q);

double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine($"O ranger do Double incia {minDouble} ate {maxDouble} ");

double arredondamento = 1.0 / 3.0;
Console.WriteLine(arredondamento);

decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
Console.WriteLine($"Ranger do Decimal inicia {minDecimal} ate {maxDecimal}");

double ad = 1.0;
double bd = 3.0;
Console.WriteLine(ad / bd);

decimal cc = 1.0M;
decimal dd = 3.0M; // Sufixo M deve ser utilizado em números para indicar constate decimal.Caso contrario compilador assumirar tipo DOUBLE.
Console.WriteLine(cc / dd);

// Exercicio 

double Circulo = 2.50;
double areaCirculo = (Math.PI) * (Circulo * Circulo) ;
Console.WriteLine($"Raio do circulo com circunferencia de {Circulo} é igual à {areaCirculo} ");


//Exercicio do FOR

int somaNumeroInteiro = 0;

for (int numeroInteiro = 1; numeroInteiro < 20; numeroInteiro++)
{
    if (numeroInteiro % 3 == 0)
    {
        somaNumeroInteiro = (somaNumeroInteiro + numeroInteiro);
    }
}
Console.WriteLine($"O resultado da soma dos numeros inteiros divisiveis por 3 é igual à : {somaNumeroInteiro}");

#endregion Exercicios_aulas_1_2

#region Exercicios_aula_3

void testandoNumerosDecimias (){

    float a = 36;
    float b = 2;

    float resultado1 =(a*b);
    Console.WriteLine($"Resultado Multiplicação : {resultado1}");
    float resultado2 =(a/b);
    Console.WriteLine($"Resultado Divisão : {resultado2}");
    float resultado3 =(a-b);
    Console.WriteLine($"Resultado Subtração : {resultado3}");
    float resultado4=(a+b);
    Console.WriteLine($"Resultado Soma : {resultado4}");
    
}
 
 testandoNumerosDecimias();




List<string> listaDeBandas = new List<string>();

void menuAdicionarBandas()
{
Console.WriteLine("----------------------------------------------------");
Console.Write("Digite [S] para adicionar uma banda, [N] para sair :");
Console.WriteLine("\n----------------------------------------------------");
string respostaInterfaceTeste = Console.ReadLine()!;
if( respostaInterfaceTeste == "S" )
{   
    Console.WriteLine("--------------------------------------");    
    Console.Write("Digite o nome de sua banda preferida : ");
    Console.WriteLine("\n--------------------------------------");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"Banda {nomeDaBanda} cadastrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    menuAdicionarBandas();

}else
{
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine($"Sua resposta foi {respostaInterfaceTeste}, pressione qualquer tecla para sair!");
    Console.WriteLine("------------------------------------------------------------------------------");
     Console.ReadKey();
};

foreach(string str in listaDeBandas){

    Console.WriteLine($"Bandas Adicionadas : {str} ");
}
    
}

menuAdicionarBandas();   

List<int> numerosInteiros = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,};
int soma=0;

foreach( var numeros in numerosInteiros){

    soma +=numeros;   
}Console.WriteLine($"Soma dos inteiros = {soma}");

List<double> numerosFloat = new List<double>{1.1,2.2,3.3,4.4,5.5,6.6,7.7,8.8};
double soma1 =0;

foreach( var d in numerosFloat){

    soma1 += d; 
}

double media = soma1 / numerosFloat.Count;
Console.WriteLine($"Media : {media}");

#endregion Exercicios_aula_3

#region  Exercicios_aula_4

void Exercicio01(){
var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};

foreach (var item in notasAlunos){

    double somarNotas =0;
    int quantidadeDeNotas = 0;
    
    foreach (var item2 in item.Value)
    {
        somarNotas += item2.Value.Sum();
        quantidadeDeNotas += item2.Value.Count;
    }

    double mediaNotas = somarNotas / quantidadeDeNotas;
    
    Console.WriteLine($"Media da aluna {item.Key} foi igual à {mediaNotas}");

}

List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
double mediaMariaEmPython = notasPythonMaria.Average();
Console.WriteLine(mediaMariaEmPython);

};

void Exercicio02(){
var alunoEnsinoMedio = new Dictionary<string, Dictionary<string, List<int>>>{
    {"Bartolomeu", new Dictionary<string, List<int>>{
        {"Matematica", new List<int>{8,9,9}},
        {"Portugues",  new List<int>{10,8,9}},
        {"Fisica", new List<int>{10,10,8}},
        {"Quimica", new List<int>{8,7,9}},
        {"Educação Fisica", new List<int>{7,8,9}}
       }
    }

};

foreach (var aluno in alunoEnsinoMedio)
{
    double somaTodasNotas = 0;
    double quantidadeDasNotas =0;

    foreach(var materias in aluno.Value){

        
        somaTodasNotas = materias.Value.Sum();
        quantidadeDasNotas = materias.Value.Count();
    
    
    double mediaParcialAluno = somaTodasNotas / quantidadeDasNotas;
    Console.WriteLine($"Media do aluno {aluno.Key},na materia {materias.Key} foi igual à : {mediaParcialAluno}");

    }

    double mediaGeralAluno = somaTodasNotas / quantidadeDasNotas;
    Console.WriteLine($"Media geral do aluno {aluno.Key} foi igual à : {mediaGeralAluno}");
}
};

void Exercicio03(){
Dictionary<string, List<int>> estoqueLoja = new Dictionary <string, List<int>>();

estoqueLoja.Add("Revolver Colt Python",new List<int>{12,10,5,8,9});
estoqueLoja.Add("Revolver Tauros RT838",new List<int>{1,5});
estoqueLoja.Add("Revolver Rossi 38 Especial",new List<int>{2,30});
estoqueLoja.Add("Revolver Ruger 357",new List<int>{35,6});
estoqueLoja.Add("Revolver SmthiWelsson Special Force",new List<int>{8,9});
estoqueLoja.Add("Revolver IMBEL 38 Forças Policias",new List<int>{50,9});
estoqueLoja.Add("Revolver Colt Federation",new List<int>{85,4});
estoqueLoja.Add("Pistola Colt 1945",new List<int>{120});

foreach (var arma in estoqueLoja)
{
    double somaEstoque = arma.Value.Sum();
    Console.WriteLine($"Modelo: {arma.Key} possui um total {somaEstoque}");
    
}
};


#endregion Exercicios_aula_4
