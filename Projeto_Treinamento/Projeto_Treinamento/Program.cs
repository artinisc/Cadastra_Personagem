using Projeto_Treinamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Projeto_Treinamento.Model
{
    public class Program
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

            //Jogo
            Jogo jogo = new Jogo();
            int resposta = 0;
            Boolean avanca = false;

            do
            {
                personagem = comeco.criarP();

                Console.WriteLine("Precione 1 para continuar.");
                Console.WriteLine("\nPrecione 2 para criar novo personagem.\n");
                Console.WriteLine("\nPrecione 3 para sair.\n");
                try{resposta = Int32.Parse(Console.ReadLine());}catch (Exception x){ }

                do
                {
                    if (resposta == 1 || resposta == 2)
                    {
                        avanca = true;
                    }
                    else
                    {
                        Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                        try{resposta = Int32.Parse(Console.ReadLine());}catch (Exception x){ }
                    }
                } while (avanca == false);

            } while (resposta == 2);

            if (resposta == 1)
            {
                jogo.jogar(personagem);
            }

            
            


        }

    }
}
