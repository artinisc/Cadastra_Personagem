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

            //partes do jogo
            CriaPersonagem comeco = new CriaPersonagem();

            //personagm
            Personagem personagem = new Personagem();
            Classe classe = new Classe();

            int repetir = 0;
            do
            {
                personagem = comeco.criar();
                classe = personagem.getClasse();

                Console.WriteLine("\n\n\nDigite 1 para continuar.");
                Console.WriteLine("\nDigite 2 para criar novo personagem.\n");
                repetir = Int32.Parse(Console.ReadLine());
            } while (repetir == 2);




        }

    }
}
