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
        public int Carisma { get; set; }
        public int Sabedoria { get; set; }
        public int Restencia { get; set; }
        public float ForcaBase { get; set; }
        public float MagiaBase { get; set; }
        public float VelocidadeBase { get; set; }
        public float VidaBase { get; set; }
        public int Forca { get; set; }
        public int Magia { get; set; }
        public int Velocidade { get; set; }
        public int Vida { get; set; }
        public int VidaAtual { get; set; }

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
                    classe = classeP;
                    erro = "sucesso";
                }
            }

            return erro;
        }

        public void defineAtributos()
        {
            this.Carisma = Convert.ToInt32(this.CarismaBase * this.classe.BonusCarisma);
            this.Sabedoria = Convert.ToInt32(this.SabedoriaBase * this.classe.BonusSabedoria);
            this.Restencia = Convert.ToInt32(this.RestenciaBase * this.classe.BonusRestencia);
            this.Forca = Convert.ToInt32(this.ForcaBase * this.classe.BonusForca + (this.Restencia * 0.3f));
            this.Magia = Convert.ToInt32(this.MagiaBase * this.classe.BonusMagia + (this.Sabedoria * 0.3f));
            this.Velocidade = Convert.ToInt32(this.VelocidadeBase * this.classe.BonusVelocidade + (this.Carisma * 0.3f));
            this.Vida = Convert.ToInt32(this.VidaBase * this.classe.BonusVida + (this.Restencia * 0.1f) + (this.Sabedoria * 0.1f) + (this.Carisma * 0.1f));
            this.VidaAtual = this.Vida;
        }

        public void calculaVida(int valor)
        {
            this.VidaAtual =+ valor;
            if (this.VidaAtual > this.Vida)
            {
                this.VidaAtual = this.Vida;
            }
        }

    }
}
