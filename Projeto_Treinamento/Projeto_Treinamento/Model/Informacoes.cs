using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    public class Informacoes
    {

        //informação do personagem
        public void infP(Personagem personagem){
            Console.WriteLine("   Personagem: " + personagem.Nome);
            Console.WriteLine("\n\n");
        }

        //informação do personagem e sua classe
        public void infPC(Personagem personagem, Classe classe)
        {
            Console.WriteLine("   Personagem: " + personagem.Nome + " (" + classe.Nome + ")");
            Console.WriteLine("   Resistencia: " + personagem.Restencia + " | Inteligencia: " + personagem.Inteligencia + " | Carisma:    " + personagem.Carisma);
            Console.WriteLine("   Força:       " + personagem.Forca +     " | Magia:        " + personagem.Magia +        " | Velocidade: " + personagem.Velocidade + " | Vitalidade: " + personagem.VitalidadeAtual + "/" + personagem.Vitalidade);
            Console.WriteLine("\n\n");
        }

    }
}
