using Projeto_Treinamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.PartesJogo
{
    public class Inicio
    {

        public Personagem cap1(Personagem personagem)
        {

            CriaPersonagem criacao = new CriaPersonagem();
            Informacoes inf = new Informacoes();
            Classe classe = new Classe();
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
            Console.WriteLine("Voce se ve no que parece ser o topo de uma montanha,");
            Console.WriteLine("e logo percebe que voce não esta com suas roupas tão pouco se parece com voce mesmo!.");
            Console.WriteLine("Estou vestido como um...");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            inf.infP(personagem);

            personagem = criacao.escolherC(personagem);
            classe = personagem.getClasse();

            Console.Clear();
            inf.infPC(personagem, personagem.getClasse());
            Console.WriteLine("Parabens! Voce acabou de selecionar sua classe.");
            Console.WriteLine("Conforme o decorrer do jogo voce vai se deparar com situações e escolhas.");
            Console.WriteLine("Escolha com sabedoria, pois o rumo do jogo pode ser alterado drasticamente conforme sua decisão.");
            Console.WriteLine("Apos algumas decisões e etapas do jogo voce tambem recebera rescompensas");
            Console.WriteLine("e muitas veses podera escolher entre algumas opções,");
            Console.WriteLine("podendo variar entre atributos para o seu personagem, equipamentos, entre outros.");
            Console.WriteLine("A seguir voce tera sua primeira escolha de recompensas.");
            Console.WriteLine("\n\n\nPrecione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();

            if (personagem.escolhas.RecebeuInformacoesLaboratorio == true)
            {
                if (classe.Nome == "Guerreiro")
                {
                    Console.Clear();
                    inf.infP(personagem);
                    Console.WriteLine("\n\n\nPrecione: \n 1 Para +5 Força \n 2 Para +5 Resistencia\n 3 Para Investida (Libera tecnica que permite avançar contra o oponente causando dano com probabilidade de derrubar)");
                    resposta = Int32.Parse(Console.ReadLine());
                    do
                    {
                        if (resposta == 1 || resposta == 2 || resposta == 3)
                        {
                            avanca = true;
                            switch (resposta)
                            {
                                case 1:
                                    personagem.ForcaBase = +5;
                                    break;
                                case 2:
                                    personagem.RestenciaBase = +5;
                                    break;
                                case 3:
                                    classe.PoderPrincipal = "Investida";
                                    personagem.setClasse(classe);
                                    classe = personagem.getClasse();
                                    break;
                            }
                            personagem.defineAtributos();
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                            resposta = Int32.Parse(Console.ReadLine());
                        }
                    } while (avanca == false);
                }
                else if (classe.Nome == "Mago")
                {
                    Console.Clear();
                    inf.infP(personagem);
                    Console.WriteLine("\n\n\nPrecione: \n 1 Para +5 Magia\n 2 Para +5 Inteligencia\n 3 Para Bola de Fogo (Libera tecnica que permite lançar uma bola de fogo sobre o oponente causando dano com probabilidade de cegueira)");
                    resposta = Int32.Parse(Console.ReadLine());
                    do
                    {
                        if (resposta == 1 || resposta == 2 || resposta == 3)
                        {
                            avanca = true;
                            switch (resposta)
                            {
                                case 1:
                                    personagem.MagiaBase = +5;
                                    break;
                                case 2:
                                    personagem.InteligenciaBase = +5;
                                    break;
                                case 3:
                                    classe.PoderPrincipal = "Bola de Fogo";
                                    personagem.setClasse(classe);
                                    classe = personagem.getClasse();
                                    break;
                            }
                            personagem.defineAtributos();
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                            resposta = Int32.Parse(Console.ReadLine());
                        }
                    } while (avanca == false);
                }
                else if (classe.Nome == "Arqueiro")
                {
                    Console.Clear();
                    inf.infP(personagem);
                    Console.WriteLine("\n\n\nPrecione: \n 1 Para +5 Velocidade \n 2 Para +5 Carisma\n 3 Para Evadir (Libera tecnica que permite saltar para loge da ameaça esquivando de qualquer ataque com probabilidade de confundir)");
                    resposta = Int32.Parse(Console.ReadLine());
                    do
                    {
                        if (resposta == 1 || resposta == 2 || resposta == 3)
                        {
                            avanca = true;
                            switch (resposta)
                            {
                                case 1:
                                    personagem.VelocidadeBase = +5;
                                    break;
                                case 2:
                                    personagem.CarismaBase = +5;
                                    break;
                                case 3:
                                    classe.PoderPrincipal = "Evadir";
                                    personagem.setClasse(classe);
                                    classe = personagem.getClasse();
                                    break;
                            }
                            personagem.defineAtributos();
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nOpção " + resposta + " Invalida! Selecione outro valor ...");
                            resposta = Int32.Parse(Console.ReadLine());
                        }
                    } while (avanca == false);
                }
            }
            else
            {

            }

            return personagem;
        }

        public Personagem cap2(Personagem personagem)
        {

            return personagem;
        }

    }
}
