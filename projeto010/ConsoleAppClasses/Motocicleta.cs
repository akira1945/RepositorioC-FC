using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppClasses
{
    public class Motocicleta : Veiculo
    {
        private int cilindrada;

        public Motocicleta(string marca, string modelo, int ano, int cilindrada) : base(marca, modelo, ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.cilindrada = cilindrada;
        }

        public int Cilindrada { get { return cilindrada; } set { cilindrada = value; } }


        public void marcaMoto(string marca)
        {
            base.NovoMarca(marca);
        }

        public void modeloMoto()
        {
            base.NovoModelo();
        }

        public void anoMoto()
        {
            base.AnoFabricado();
        }

        public void novaCilindrada()
        {
            Console.WriteLine($"Potencia do motor é {cilindrada}");
            Console.WriteLine($"Potencia do motor é {Cilindrada}");
        }


    }
}