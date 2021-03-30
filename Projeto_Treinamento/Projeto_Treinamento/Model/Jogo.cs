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

        public void jogar(Personagem personagem)
        {

            personagem = etapaPrologo(personagem);
            if (personagem.estado == true)
            {
                personagem = etapaInicio(personagem);
            }
            if (personagem.estado == true)
            {
                personagem = etapaPrimeirasDescobertas(personagem);
            }
            if (personagem.estado == true)
            {

            }



        }

        public Personagem etapaPrologo(Personagem personagem)
        {
            Prologo prologo = new Prologo();
            personagem = prologo.p1(personagem);
            return personagem;
        }

        public Personagem etapaInicio(Personagem personagem)
        {
            Inicio inicio = new Inicio();
            personagem = inicio.cap1(personagem);
            return personagem;
        }

        public Personagem etapaPrimeirasDescobertas(Personagem personagem)
        {
            Inicio inicio = new Inicio();
            personagem = inicio.cap2(personagem);
            return personagem;
        }

    }
}
