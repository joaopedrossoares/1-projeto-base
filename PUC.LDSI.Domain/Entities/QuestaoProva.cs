using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoProva : Entity
    {

        public int QuestaoId { get; set; }
        public int ProvaId { get; set; }
        public double Nota { get; set; }
        public Prova Prova { get; set; }
        public Questao Questao { get; set; }
        public List<OpcaoProva> OpçoesProvas { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (ProvaId == 0)
            {
                erros.Add(" O Id da Prova presisa ser informada ");
            }
            if (QuestaoId == 0)
            {
                erros.Add(" O Id da questão presisa ser informada ");
            }
            return erros.ToArray();
        }


    }
}
