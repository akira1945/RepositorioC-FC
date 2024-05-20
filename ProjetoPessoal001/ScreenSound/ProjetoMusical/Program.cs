using System.ComponentModel.DataAnnotations;
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

#region ScreenSound

String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

List<string> listaDasBandas= new List<string>{"U2","Verdade Secreta","Metallica","AA1"};

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
        case 3: Console.WriteLine("Você escolheu a opção : " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção : " + opcaoEscolhida);
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
    Console.WriteLine("********************");
    Console.WriteLine("Registros de bandas");
    Console.WriteLine("********************\n");
    Console.Write("Digite o nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"Banda {nomeDaBanda} registrada com sucesso!!!");
    Thread.Sleep(2000);//faz o programa esperar um tempo(milesegundo)
    Console.Clear();
    ExibirOpcoesDoMenu();
 };

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("Exibindo todas as bandas registradas:");
    Console.WriteLine("*************************************\n");
    // for (int i = 0; i< listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // };
    foreach (var banda in listaDasBandas)
    {
        Console.WriteLine($"Banda : {banda}");
    };
    Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal!!!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();

#endregion ScreenSound

#region Exercicios_aulas_1_2
/*
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
*/
#endregion Exercicios_aulas_1_2

#region Exercicios_aula_3
/*
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

void bandasPreferidas()
{

int i = 5;
List<string> listaDeBandas = new List<string>();

Console.Write("Digite o nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"Banda {nomeDaBanda} cadastrada com sucesso");
    Thread.Sleep(2000);
    if (i > 0 || i < 5 )
    {   
        Console.Clear();
        bandasPreferidas();       
    } else {
         Console.WriteLine("Pressione qualquer tecla para sair");
         Console.ReadKey();
    }
      
}
 bandasPreferidas();
*/
#endregion Exercicios_aula_3