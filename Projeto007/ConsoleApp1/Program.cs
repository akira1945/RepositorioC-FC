// Estruturas logicas

//IF e ELSE



// Operador Ternário

using System.Collections;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 5;
        string resultado = numero > 0 ? "Positivo" : "Negativo ou Zero";
        Console.WriteLine(resultado);

        // Swutch Case

        string variavel = "valor";
        switch (variavel)
        {
            case "valor":
            case "valor1":
                Console.WriteLine("Valo2");
                break;
            case "valor2":
            default:
                Console.WriteLine("Sem valor");
                break;
        };

        // Operadores Lógicos e Comparação

        // && (and);
        // || (or);
        // == (Igaul a);
        // !=(<>);
        // !(NOT); NEGAÇÃO

        // loop

        for (int I = 0; I < 10; I++) //FOR

        {

            Console.WriteLine(I);

        }

        //WHILE

        double temperaturaMotor = 150.0;
        double temperaturaSegura = 50.0;

        while (temperaturaMotor > temperaturaSegura)
        {

            temperaturaMotor -= 5.0;
            Console.WriteLine($"Resfriando o motor... temperatura {temperaturaMotor}");

        }
        Console.WriteLine("Motor Desligado");

        //DO WHILE





        //ARRAYS

        int[] arraydois = new int[100];

        //MATRIZ - ARRAYS VARIAS DIMENSOES

        int[,] matriz = { { }, { } };

        //ForEach

        string[] frutas = ["Maçã", "Banana", "Cerveja"];
        foreach (var fruta in frutas)
        {
            Console.WriteLine($"Hoje tem essa fruta : {frutas}");
        }
    }
}