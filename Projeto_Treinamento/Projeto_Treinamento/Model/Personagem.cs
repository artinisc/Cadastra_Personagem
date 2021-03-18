using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    class Personagem
    {

        public int id { get; set; }
        public string nome { get; set; }
        public int forca { get; set; }
        public int magia { get; set; }
        public int velocidade { get; set; }
        public int vida { get; set; }

        private Classe classe { get; set; }
        
        public Classe getClasse()
        {
            return classe;
        }

        public string setClasse(Classe classeP)
        {
            string erro = "";
            if (classeP.nome.Equals("Guerreiro") || classeP.nome.Equals("Mago"))
            {
                this.classe = classeP;
                erro = "sucesso";
            }
            else
            {
                erro = "falha";
            }

            return erro;
        }



    }
}
