using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    class CriaPersonagem
    {

        public Personagem criar()
        {

            //estrutura
            List<Classe> classes = new List<Classe>();

            //personagm
            Personagem personagem = new Personagem();
            Classe classe = new Classe();

            //verificadores
            Boolean verifica = false;
            int recebeEntrada = 0;
            string retorno = "";
            int contC = 0;

            //seta id e nome do personagem
            classes = classe.criaClasses();
            personagem.Id = 1;
            Console.Clear();
            Console.WriteLine("Qual o seu nome?");
            personagem.Nome = Console.ReadLine();

            //seta a classe do personagem
            Console.Clear();
            Console.WriteLine("Escolha sua classe:\n");
            contC = 0;
            foreach (Classe C in classes)
            {
                contC++;
                Console.WriteLine("Digite " + contC + " para " + C.Nome + "\n");
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
                    //Console.Clear();
                    Console.WriteLine("Opção Invalida! Escolha outra opção para selecionar sua classe:\n");
                    contC = 0;
                    foreach (Classe C in classes)
                    {
                        contC++;
                        Console.WriteLine("Digite " + contC + " para " + C.Nome + "\n");
                    }
                    recebeEntrada = Int32.Parse(Console.ReadLine());
                    recebeEntrada--;
                }
            } while (verifica == false);

            //obtem a classe do ersnagem
            Console.Clear();
            classe = personagem.getClasse();

            personagem.CarismaBase = 10;
            personagem.SabedoriaBase = 10;
            personagem.RestenciaBase = 10;
            personagem.ForcaBase = 10;
            personagem.MagiaBase = 10;
            personagem.VelocidadeBase = 10;
            personagem.VidaBase = 50;

            personagem = personagem.defineAtributos(personagem);

            //exibe personagem
            Console.WriteLine("\nNome: " + personagem.Nome + "\nClasse: " + classe.Nome);
            Console.WriteLine("\nCarisma: " + personagem.Carisma + " - Resistencia: " + personagem.Restencia + " / Força: " + personagem.Forca + " - Velocidade: " + personagem.Velocidade + " - Vida: " + personagem.Vida);

            return personagem;

        }

    }
}
