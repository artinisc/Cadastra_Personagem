using Projeto_Treinamento.PartesJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    public class Jogo
    {

        public void jogar(Personagem personagem, Classe classe)
        {

            personagem = etapaPrologo(personagem, classe);
            if (personagem.estado == true)
            {
                personagem = etapaInicio(personagem, classe);
            }
            if (personagem.estado == true)
            {
                
            }



        }

        public Personagem etapaPrologo(Personagem personagem, Classe classe)
        {
            Prologo prologo = new Prologo();
            personagem = prologo.p1(personagem);
            return personagem;
        }

        public Personagem etapaInicio(Personagem personagem, Classe classe)
        {
            Inicio inicio = new Inicio();
            personagem = inicio.cap1(personagem);
            return personagem;
        }

    }
}
