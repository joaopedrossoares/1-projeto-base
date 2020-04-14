using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
	public class QuestaoProva : Entity
	{
		public int QuestaoId { get; set; }
		public int ProvaId { get; set; }
		public decimal Nota { get; set; }

		// ---- Relacionamentos ----

		public Questao Questao { get; set; }
		public Prova Prova { get; set; }
		public List<OpcaoProva> OpcoesProvas { get; set; }

		public override string[] Validate()
		{
            var erros = new List<string>();
            if (QuestaoId == 0)
                erros.Add("A questão precisa ser informada!");
            if (ProvaId  == 0)
                erros.Add("A prova precisa ser informada!");
            
            return erros.ToArray();
        }
	}
}
