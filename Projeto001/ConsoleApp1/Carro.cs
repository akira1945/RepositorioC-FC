


namespace ConsoleApp1;

public class Carro
{
    private double incremento;

    public string Modelo {get; set;}

    public string Cor {get; set;}

    public int Ano { get; set; }

    public string Placa { get; set; }

    public double VelocidadeAtual { get; set; }

    public string Chassis { get; set; }





    public Carro(string modelo, int ano, string placa, double velocidadeatual, string cor, string chassis ) 
    {

        this.Modelo = modelo;
        this.Ano = ano;
        this.Placa = placa;
        this.VelocidadeAtual = velocidadeatual;
        this.Cor = cor;
        this.Chassis = chassis;

    }

    public Carro()
    {
        
    }

    public void Acelerar (double incremento, int outraCoisa )
    {
        this.VelocidadeAtual += incremento;
        Console.WriteLine($"velocidade do carro subiu para {this.VelocidadeAtual}");
    }

    public void Frear (double decremento)
    {
        this.VelocidadeAtual += incremento;
        Console.WriteLine($"velocidade do carro diminuiu para {this.VelocidadeAtual}");
    }

    public string Ligar ()
    {
        //ConsoleApp1.writeline($" O carro esta ligado {this.VelocidadeAtual}")
       return "O carro esta ligado";
    }
}