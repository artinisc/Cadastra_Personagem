using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Treinamento.Model
{
    class Classe
    {

        public int id { get; set; }
        public string nome { get; set; }

        public int bonusForca { get; set; }
        public int bonusMagia { get; set; }
        public int bonusVelocidade { get; set; }
        public int bonusVida { get; set; }

        public string vantagem { get; set; }

        public string poder1 { get; set; }
        public string poder2 { get; set; }
        public string poder3 { get; set; }
        public string poderReativo { get; set; }

        public List<Classe> criaClasses(){

            List<Classe> classes = new List<Classe>();

            for (int id = 0; id <= 3; id++)
            {
                Classe modelo = new Classe();
                switch (id){
                    case 1:
                        modelo.id = id;
                        modelo.nome = "Guerreiro";
                        classes.Add(modelo);
                    break;
                    case 2:
                        modelo.id = id;
                        modelo.nome = "Mago";
                        classes.Add(modelo);
                    break;
                    case 3:
                        modelo.id = id;
                        modelo.nome = "Arqueiro";
                        classes.Add(modelo);
                    break;
                }
            }


                return classes;
        }

    }
}
