using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.MVC.Models
{
    public class PublicacaoViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Turma")]
        public int TurmaId { get; set; }

        [DisplayName("Avaliação")]
        public int AvaliacaoId { get; set; }

        [DisplayName("Publicado Em")]
        public DateTime DataCriacao { get; set; }

        [DisplayName("Início")]
        [Required(ErrorMessage = "O campo Início é obrigatório.")]
        public DateTime DataInicio { get; set; }

        [DisplayName("Fim")]
        [Required(ErrorMessage = "O campo Fim é obrigatório.")]
        public DateTime DataFim { get; set; }

        [DisplayName("Valor da prova")]
        [Required(ErrorMessage = "O campo Valor da prova é obrigatório.")]
        public int ValorProva { get; set; }

        public AvaliacaoViewModel Avaliacao;
        //display? TODO - olha joao
        public TurmaViewModel Turma;
    }
}