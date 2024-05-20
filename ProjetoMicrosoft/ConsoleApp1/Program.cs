// UTILIZAÇÃO DO IF

// == distingue o teste de igualdade de atribuição
// && representa "And"
// || para representar "or"
// ++ Incremnta valor

using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        int A = 5;
        int B = 3;
        int C = A + B;
        int D = A + B + C;

        if (A + B > 10)
            Console.WriteLine($"Soma atende os criterios do IF : Resultado = {C}");
        else
            Console.WriteLine($"Valor não exibido, soma é menor que 10: Resultado = {C}");

        if (A + B + C > 10 && A == B)
        {
            Console.WriteLine($"Soma atende os criterios do IF : Resultado = {C}");
            Console.WriteLine("O primeiro numero é igual ao segundo");
        }
        else
        {
            Console.WriteLine($"Valor não exibido, soma é menor que 10: Resultado = {C}");
            Console.WriteLine($"O primeiro numero não é igual ao segundo");
        }

        if (A + B + C > 10 || A == B)
        {
            Console.WriteLine($"Soma atende os criterios do IF : Resultado = {D}");
            Console.WriteLine(value: $"Ou primeiro numero é igual ao segundo? A= [{A}] e  B=[{B}]");
        }
        else
        {
            Console.WriteLine($"Valor não exibido, soma é menor que 10: Resultado = {D}");
            Console.WriteLine(value: $"Ou primeiro numero é igual ao segundo? A=[{A}] e B=[{B}]");
        }
        //----------------------------------------------------------------------------------------------------

        // LOOPS - WHILE

        int contador = 10;
        while (contador >= 10 && contador < 100)
        {
            Console.WriteLine($"Olá Mundo! Estou contando de {contador}");
            contador++;
        };

        int contador2 = 1;

        do
        {
            Console.WriteLine($"Olá Mundo! Estou contando de {contador2}");
            contador2++;
        } while (contador2 < 1000);

        // LOOPS - FOR (DECLARO VARIAVEL; CONDIÇÃO ; AÇÃO(INTERADOR)); ele faz a mesma função do WHILE DO;

        for (int contador3 = 0; contador3 <= 100; contador3++)
        {
            Console.WriteLine($"Olá Mundo! estou utilizando o FOR, agora iniciei a contagem: {contador3}");

        };

        // exercicio.

        for (int linhas = 1; linhas <= 10; linhas++)
        {
            Console.WriteLine($"Linhas inicam {linhas}");
        };

        for (char colunas = 'a'; colunas <= 'j'; colunas++)
        {
            Console.WriteLine($"Colunas inciam {colunas}");
        };

        for (char colunas = 'a'; colunas <= 'j'; colunas++)
        {
            for (int linhas = 1; linhas <= 10; linhas++)
            {
                Console.WriteLine($"Celulas ({colunas} , {linhas})");
            }
        };

        for (char colunas = 'a'; colunas <= 'z'; colunas++){
          for (int linhas = 1 ; linhas <= 26 ; linhas++){
            Console.WriteLine($"Celulas [{colunas} ; {linhas}]");
          }
        }

        int somaInteiros = 0; // soma de numeros inteiros ate 20

        for ( int numerosInteiros = 1; numerosInteiros <=20; numerosInteiros++ ){
          if (numerosInteiros % 3 == 0){
            somaInteiros = somaInteiros + numerosInteiros;
          }        
        }
        Console.WriteLine($"Soma dos numeros inteiros divisiveis por 3 é igual à : {somaInteiros}");

        int subtracaoInteiros = 0;

        for (int numerosInteiros = 1 ; numerosInteiros <=100; numerosInteiros++ ){

          if (numerosInteiros % 3 ==0){
            subtracaoInteiros = subtracaoInteiros - numerosInteiros;            
          }
        }
        Console.WriteLine($"Subtração dos numeros inteiros divisiveis por 3 é igual à : {subtracaoInteiros}");

        double somaDecimais =0;

        for (double numerosDecimais =1; numerosDecimais <=2000; numerosDecimais++){

          if ( numerosDecimais % 10 ==0){
            somaDecimais = somaDecimais + numerosDecimais;
          }
        }
        Console.WriteLine($"Soma dos numeros inteiros divisiveis por 10 é igual à : {somaDecimais}");
    }

}


