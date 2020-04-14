using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
	public class Avaliacao : Entity
	{
		public int ProfessorId { get; set; }
		public string Disciplina { get; set; }
		public string Materia { get; set; }
		public string Descricao { get; set; }

		// ---- Relacionamentos ----

		public Professor Professor { get; set; }
		public List<Prova> Provas { get; set; }
		public List<Publicacao> Publicacoes { get; set; }
		public List<Questao> Questoes { get; set; }

		public override string[] Validate()
		{
            var erros = new List<string>();
            if (ProfessorId == 0)
                erros.Add("O professor precisa ser informado!");
            if (string.IsNullOrEmpty(Disciplina))
                erros.Add("A disciplina precisa ser informada!");
            if (string.IsNullOrEmpty(Materia))
                erros.Add("A matéria precisa ser informada!");
            if (string.IsNullOrEmpty(Descricao))
                erros.Add("A descrição precisa ser informada!");

            return erros.ToArray();


        }
    }
}
