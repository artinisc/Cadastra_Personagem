using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    class Classe
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public float BonusForca { get; set; }
        public float BonusMagia { get; set; }
        public float BonusVelocidade { get; set; }
        public float BonusVida { get; set; }

        public float BonusCarisma { get; set; }
        public float BonusSabedoria { get; set; }
        public float BonusRestencia { get; set; }

        public string Vantagem { get; set; }

        public string PoderPrincipal { get; set; }
        public string PoderSecundario { get; set; }
        public string PoderDefencivo { get; set; }
        public string PoderReativo { get; set; }

        public List<Classe> criaClasses(){

            List<Classe> classes = new List<Classe>();

            for (int id = 0; id <= 3; id++)
            {
                Classe modelo = new Classe();
                switch (id){
                    case 1:
                        modelo.Id = id;
                        modelo.Nome = "Guerreiro";
                        BonusForca = 1.5f;
                        BonusMagia = 1.0f;
                        BonusVelocidade = 1.2f;
                        BonusVida = 1.3f;
                        BonusCarisma = 1.0f;
                        BonusSabedoria = 1.0f;
                        BonusRestencia = 1.3f;
                        Vantagem = "";
                        PoderPrincipal = "";
                        PoderSecundario = "";
                        PoderDefencivo = "";
                        PoderReativo = "";
                        classes.Add(modelo);
                    break;
                    case 2:
                        modelo.Id = id;
                        modelo.Nome = "Mago";
                        BonusForca = 1.0f;
                        BonusMagia = 1.5f;
                        BonusVelocidade = 1.3f;
                        BonusVida = 1.2f;
                        BonusCarisma = 1.0f;
                        BonusSabedoria = 1.3f;
                        BonusRestencia = 1.0f;
                        Vantagem = "";
                        PoderPrincipal = "";
                        PoderSecundario = "";
                        PoderDefencivo = "";
                        PoderReativo = "";;
                        classes.Add(modelo);
                    break;
                    case 3:
                        modelo.Id = id;
                        modelo.Nome = "Arqueiro";
                        BonusForca = 1.3f;
                        BonusMagia = 1.0f;
                        BonusVelocidade = 1.5f;
                        BonusVida = 1.2f;
                        BonusCarisma = 1.3f;
                        BonusSabedoria = 1.0f;
                        BonusRestencia = 1.0f;
                        Vantagem = "";
                        PoderPrincipal = "";
                        PoderSecundario = "";
                        PoderDefencivo = "";
                        PoderReativo = "";
                        classes.Add(modelo);
                    break;
                }
            }
                return classes;
        }

    }
}
