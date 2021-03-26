using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    public class CriaPersonagem
    {

        public Personagem criarP()
        {

            //personagm
            Personagem personagem = new Personagem();
            Informacoes inf = new Informacoes();

            //seta id e nome do personagem
            personagem.Id = 1;
            Console.Clear();
            Console.WriteLine("Qual o seu nome?");
            personagem.Nome = Console.ReadLine();

            //obtem a classe do ersnagem
            Console.Clear();
            
            personagem.CarismaBase = 10;
            personagem.InteligenciaBase = 10;
            personagem.RestenciaBase = 10;
            personagem.ForcaBase = 10;
            personagem.MagiaBase = 10;
            personagem.VelocidadeBase = 10;
            personagem.VitalidadeBase = 50;
            personagem.estado = true;

            //exibe personagem
            inf.infP(personagem);
            
            return personagem;

        }

        public Personagem escolherC(Personagem personagem){

            //estrutura
            List<Classe> classes = new List<Classe>();
            Classe classe = new Classe();
            Informacoes inf = new Informacoes();

            //verificadores
            Boolean verifica = false;
            int recebeEntrada = 0;
            string retorno = "";
            int contC = 0;

            classes = classe.criaClasses();

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

            classe = personagem.getClasse();

            personagem.defineAtributos();

            Console.Clear();

            return personagem;
        }

    }
}
