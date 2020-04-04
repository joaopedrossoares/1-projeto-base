using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Publicacao : Entity
    {

        public int ValorProva { get; set; }
        public DateTime DataFim { get; set; }
        public int TurmaId { get; set; }
        public int AvaliacaoId { get; set; }
        public DateTime DataInicio { get; set; }
        public Turma Turma { get; set; }
        public Avaliacao Avaliacao { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (AvaliacaoId == 0)
            {
                erros.Add(" O Id da avaliação presisa ser informada ");
            }
            if (TurmaId == 0)
            {
                erros.Add(" O Id da turma presisa ser informada ");
            }
            if (DateTime.MinValue == DataInicio)
            {
                erros.Add(" A data de inicio presisa ser informada ");
            }
            if (DateTime.MinValue == DataFim)
            {
                erros.Add(" A data de Fim presisa ser informada ");
            }
            if (DateTime.MinValue >= DataFim)
            {
                erros.Add(" A data de Fim presisa ser maior que a data de inicio ");
            }
            if (ValorProva <= 0)
            {
                erros.Add(" O valor da prova deve ser maior que 0 ");
            }

            return erros.ToArray();
        }



    }
}
