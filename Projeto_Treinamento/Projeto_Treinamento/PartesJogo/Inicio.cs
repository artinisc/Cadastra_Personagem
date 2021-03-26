using Projeto_Treinamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.PartesJogo
{
    class Inicio
    {

        public Personagem cap1(Personagem personagem)
        {

            CriaPersonagem criacao = new CriaPersonagem();
            Informacoes inf = new Informacoes();
            int resposta = 0;
            Boolean avanca = false;

            Console.Clear();
            inf.infP(personagem);
            Console.WriteLine("CAPITULO I - UMA JORNADA INESPERADA\n\n");
            Console.WriteLine("Felismente essa sensação estranha logo passa, as coisas parecem estar se estabilizando.");
            Console.WriteLine("Para um laboratorio voce sente uma estranha brisa que carrega com sigo um cheiro fresco do orvalho da manhã...");
            Console.WriteLine("Aos poucos sua visão vai ficando mais clara e!!!");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            inf.infP(personagem);
            Console.WriteLine("QUE!!! ONDE ESTOU!!!");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            inf.infP(personagem);
            Console.WriteLine("Voce se ve no que parece ser o topo de uma montanha, e espera voce não esta com suas roupas tão pouco se parece com voce mesmo!");
            Console.WriteLine("Estou vestido como um...");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            inf.infP(personagem);

            personagem = criacao.escolherC(personagem);

            Console.Clear();
            inf.infPC(personagem, personagem.getClasse());
            Console.WriteLine("Parabens! Voce acabou de selecionar sua classe.");
            Console.WriteLine("Conforme o decorrer do jogo voce vai se deparar com situações e escolhas.");
            Console.WriteLine("Escolha com sabedoria, pois o rumo do jogo pode ser alterado drasticamente conforme sua decisão.");
            Console.WriteLine("Apos algumas decisões e etapas do jogo voce tambem recebera rescompensas e muitas veses podera escolher entre uma e outra,");
            Console.WriteLine(" podendo variar entre atributos para o seu personagem, equipa");
            Console.ReadLine();
            Console.Clear();

            return personagem;
        }

    }
}
