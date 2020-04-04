using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Questao : Entity
    {
        public int AvaliacaoId { get; set; }
        public int Tipo { get; set; }
        public string Enunciado { get; set; }
        public List<OpcaoAvaliacao> OpcoesAvaliacao { get; set; }
        public List<QuestaoProva> QuestoesProva { get; set; }
        public Avaliacao Avaliacao { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (AvaliacaoId == 0)
            {
                erros.Add(" O Id da Avaliação presisa ser informada ");
            }
            if (Tipo == 1 || Tipo == 2)
            {
                erros.Add(" O tipo dve ser prenchido 1 pata Múltipla Escolha e 2 para Verdadeiro ou Falso ");

            }
            if (string.IsNullOrEmpty(Enunciado))
            {
                erros.Add(" O enunciado presisa ser informada");
            }
            return erros.ToArray();
        }

    }
}
