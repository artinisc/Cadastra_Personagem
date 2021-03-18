using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    class Jogo
    {

        public void jogar()
        {

            List<Classe> classes = new List<Classe>();
            Classe classe = new Classe();
            Personagem personagem = new Personagem();
            int recebeEntrada = 0;
            Boolean verifica = false;
            string retorno = "";
            int contC = 0;

            classes = classe.criaClasses();
            personagem.id = 1;

            Console.WriteLine("Qual o seu nome?");
            personagem.nome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Escolha sua classe:\n");
            contC = 0;
            foreach (Classe C in classes)
            {
                contC++;
                Console.WriteLine("Digite " + contC + " para " + C.nome + "\n");
            }
            recebeEntrada = Int32.Parse(Console.ReadLine());
            recebeEntrada--;

            do
            {

                try
                {
                    retorno = personagem.setClasse(classes[recebeEntrada]);
                    if (retorno.Equals("sucesso"))
                    {
                        verifica = true;
                    }
                    else
                    {
                        verifica = false;
                    }
                }
                catch (Exception ex) { };

                if (verifica == false)
                {
                    Console.Clear();
                    Console.WriteLine("Opção Invalida! Escolha outra opção para selecionar sua classe:\n");
                    contC = 0;
                    foreach (Classe C in classes)
                    {
                        contC++;
                        Console.WriteLine("Digite " + contC + " para " + C.nome + "\n");
                    }
                    recebeEntrada = Int32.Parse(Console.ReadLine());
                    recebeEntrada--;
                }

            } while (verifica == false);

            Console.Clear();
            classe = personagem.getClasse();
            Console.WriteLine("Seu Personagem é:\n Nome: " + personagem.nome + "\n Classe: " + classe.nome);

        }

    }
}
