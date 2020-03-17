using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Avaliacao : Entity
    {
        public int ProfessorId { get; set; }
        public string Diciplina { get; set; }
        public string Materia { get; set; }
        public string Descricao { get; set; }
        public List<Questao> Questoes { get; set; }
        public List<Prova> Provas { get; set; }
        public List<Publicacao> Publicacoes { get; set; }
        public Professor Professor { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (ProfessorId == 0)
            {
                erros.Add(" O professor presisa ser informada ");
            }
            if (string.IsNullOrEmpty(Diciplina))
            {
                erros.Add(" A disiplina deve ser informado ");

            }
            if (string.IsNullOrEmpty(Materia))
            {
                erros.Add(" A materia deve ser informado ");

            }
            if (string.IsNullOrEmpty(Descricao))
            {
                erros.Add(" A descrição deve ser informado ");

            }
            return erros.ToArray();
        }
    }
}
