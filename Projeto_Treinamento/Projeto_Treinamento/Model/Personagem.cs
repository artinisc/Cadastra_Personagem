using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    class Personagem
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public float CarismaBase { get; set; }
        public float SabedoriaBase { get; set; }
        public float RestenciaBase { get; set; }
        public float Carisma { get; set; }
        public float Sabedoria { get; set; }
        public float Restencia { get; set; }
        public float ForcaBase { get; set; }
        public float MagiaBase { get; set; }
        public float VelocidadeBase { get; set; }
        public float VidaBase { get; set; }
        public float Forca { get; set; }
        public float Magia { get; set; }
        public float Velocidade { get; set; }
        public float Vida { get; set; }

        private Classe classe { get; set; }
        
        public Classe getClasse()
        {
            return classe;
        }

        public string setClasse(Classe classeP)
        {

            List<Classe> classes = new List<Classe>();
            Classe cla = new Classe();
            classes = cla.criaClasses();
            string erro = "falha";

            foreach (Classe C in classes)
            {
                if (classeP.Nome.Equals(C.Nome))
                {
                    this.classe = classeP;
                    erro = "sucesso";
                }
            }

            return erro;
        }

        public Personagem defineAtributos(Personagem personagem)
        {
            this.Carisma = this.CarismaBase * this.classe.BonusCarisma;
            this.Sabedoria = this.SabedoriaBase * this.classe.BonusSabedoria;
            this.Restencia = this.RestenciaBase * this.classe.BonusRestencia;
            this.Forca = this.ForcaBase + (this.Restencia * 0.3f);
            this.Magia = this.MagiaBase + (this.Sabedoria * 0.3f);
            this.Velocidade = this.VelocidadeBase + (this.Carisma * 0.3f);
            this.Vida = this.VidaBase + (this.Restencia * 0.1f) + (this.Restencia * 0.1f) + (this.Restencia * 0.1f);

            return personagem;
        }


    }
}
