using Projeto_Treinamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Projeto_Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Program executa = new Program();
            executa.inicia();
        }

        public void inicia()
        {

            Jogo comeco = new Jogo();

            comeco.jogar();

            Console.WriteLine("\n\n\nDigite 1 para jogar novamente.");
            Console.WriteLine("\nDigite 2 para sair.\n");
            int repetir = Int32.Parse(Console.ReadLine());

            if (repetir == 1)
            {
                comeco.jogar();
            }

        }

    }
}
