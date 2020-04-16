using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PUC.LDSI.MVC.Models
{
    public class AvaliacaoViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Professor")]
        public string Professor { get; set; }

        [Required(ErrorMessage = "A Disciplina é requerido.")]
        [MaxLength(100, ErrorMessage = "Informe no maximo {0} caracteres.")]
        [DisplayName("Disciplina")]
        public string Disciplina { get; set; }

        [Required(ErrorMessage = "A Materia é requerido.")]
        [MaxLength(100, ErrorMessage = "Informe no maximo {0} caracteres.")]
        [DisplayName("Materia")]
        public string Materia { get; set; }

        [Required(ErrorMessage = "A Descricao é requerido.")]
        [MaxLength(100, ErrorMessage = "Informe no maximo {0} caracteres.")]
        [DisplayName("Descricao")]
        public string Descricao { get; set; }

        public List<QuestaoAvaliacaoViewModel> ListQuestaoAvaliacao { get; set; }

        /* TODO Conterá uma lógica de validação da avaliação;
Será válida a avaliação que possua pelo menos uma questão e que todas as questões estejam válidas de acordo com as regras descritas no caso de uso US2 do nosso trabalho;
Utilize na lógica validação pelo atributo Erros que será criado na QuestaoAvaliacaoViewModel.*/
        public bool EhValida { get; set;}


    }
}
