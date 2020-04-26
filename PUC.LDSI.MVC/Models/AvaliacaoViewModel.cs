using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PUC.LDSI.Domain.Entities;

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

        public List<QuestaoAvaliacaoViewModel> Questoes = new List<QuestaoAvaliacaoViewModel>();

        public bool EhValida
        {
            get
            {
                if (Questoes.Count == 0)
                    return false;
                foreach (QuestaoAvaliacaoViewModel item in Questoes)
                {
                    if (!item.Erro.Equals(""))
                        return false;
                }
                return true;
            }
        }
    }
}
