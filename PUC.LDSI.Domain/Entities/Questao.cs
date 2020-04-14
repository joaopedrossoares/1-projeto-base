using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
	public class Questao : Entity
	{
		public int AvaliacaoId { get; set; }
		public byte Tipo { get; set; }
		public string Enunciado { get; set; }

		//---- Relacionamentos ----

		public Avaliacao Avaliacao { get; set; }
		public List<QuestaoProva> QuestoesProvas { get; set; }
		public List<OpcaoAvaliacao> OpcoesAvaliacoes { get; set; }

		public override string[] Validate()
		{
            var erros = new List<string>();
            if (AvaliacaoId == 0)
                erros.Add("A avaliação precisa ser informada!");
            if (Tipo == 0)
                erros.Add("O tipo da prova precisa ser informado! 1 (Múltipla Escolha) ou 2 (Verdadeiro ou Falso);");
            if (string.IsNullOrEmpty(Enunciado))
                erros.Add("O enunciado precisa ser informado!");
            return erros.ToArray();
        }
	}
}
