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
            Classe criada = new Classe();
            int contId = 0;

            id++;

            criada.id = contId;
            criada.nome = "Guerreiro";

            classes.Add(criada);

            criada.id = 0;
            criada.nome = "";
            id++;

            criada.id = contId;
            criada.nome = "Mago";

            classes.Add(criada);

            return classes;
        }

    }
}
