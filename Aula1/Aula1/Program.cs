using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Carro criado,velocidade inicial: " + c.Velocidade);
            c.Acelerar();
            c.Acelerar();

            AcelerarBatante(c);
            Console.WriteLine("Carro, velocidade atual: " + c.Velocidade);

            Console.ReadKey();

        }


        static void AcelerarBatante(IMeioTransporte meioTransporte)
        {
            for (int i=0; i<10; i++)
            {
                meioTransporte.Acelerar();
            }
        }

    }
}
