using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Prova : Entity
    {

        public int AvalicaoId { get; set; }
        public int AlunoId { get; set; }
        public DateTime DataProva { get; set; }
        public double NotaObtida { get; set; }
        public Aluno aluno { get; set; }
        public Avaliacao avaliacao { get; set; }
        public List<QuestaoProva> QuestoesProva { get; set; }


        public override string[] Validate()
        {
            var erros = new List<string>();

            if (AvalicaoId == 0)
            {
                erros.Add(" A AvaliÇão ID presisa ser informada ");
            }
            if (AlunoId == 0)
            {
                erros.Add(" O aluno ID presisa ser informada ");
            }
            if (DateTime.MinValue == DataProva)
            {
                erros.Add(" A data da prova deve ser informado ");

            }
            return erros.ToArray();
        }





    }
}
