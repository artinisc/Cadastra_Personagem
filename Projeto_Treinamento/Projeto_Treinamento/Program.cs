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
            Program jogar = new Program();
            jogar.jogo();
        }

        public void jogo()
        {

            List<Classe> classes = new List<Classe>();
            Classe classe = new Classe();
            Personagem personagem = new Personagem();
            int recebeEntrada = 0;
            Boolean verifica = false;
            string retorno = "";

            classes = classe.criaClasses();

            personagem.id = 1;

            Console.WriteLine("Qual o seu nome?");
            personagem.nome = Console.ReadLine();

            Console.WriteLine("Escolha sua classe:\n Digite 1 para " + classes[0].nome + "\n Digite 2 para " + classes[1].nome);
            recebeEntrada = Int32.Parse(Console.ReadLine());

            do{
                if (recebeEntrada == 1)
                {
                    verifica = true;
                    retorno = personagem.setClasse(classes[1]);
                    if (retorno.Equals("sucesso"))
                    {
                        Console.WriteLine("Classe adicionada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Falha ao adicionar classe!");
                    }
                }
                else if (recebeEntrada == 2)
                {
                    verifica = true;
                    retorno = personagem.setClasse(classes[2]);
                    if (retorno.Equals("sucesso"))
                    {
                        Console.WriteLine("Classe adicionada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Falha ao adicionar classe!");
                    }
                }
                else
                {
                    verifica = false;
                    Console.WriteLine("Opção Invalida!/n Escolha sua classe:\n Digite 1 para " + classes[0] + "\n Digite 2 para " + classes[1]);
                    recebeEntrada = Int32.Parse(Console.ReadLine());
                }
            }while(verifica == false);

            classe = personagem.getClasse();
            Console.WriteLine("Seu Personagem é:\n Nome:" + personagem.nome + "\n Classe:" + classe.nome);
            personagem.nome = Console.ReadLine();


        }



    }
}
