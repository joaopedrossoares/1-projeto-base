using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.MVC.Models
{
    public class QuestaoAvaliacaoViewModel
    {
        QuestaoAvaliacaoViewModel Questao = new QuestaoAvaliacaoViewModel();
        OpcaoAvaliacaoViewModel Opcao = new OpcaoAvaliacaoViewModel();

        [Key]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public int AvaliacaoId { get; set; }

        [Required(ErrorMessage = "O Tipo é requerido.")]
        [DisplayName("Tipo")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "O Enunciado é requerido.")]
        [MaxLength(225, ErrorMessage = "Informe no maximo {0} caracteres.")]
        [DisplayName("Enunciado")]
        public string Enunciado { get; set; }

        public AvaliacaoViewModel Avaliacao = new AvaliacaoViewModel();

        public List<OpcaoAvaliacaoViewModel> Opcoes = new List<OpcaoAvaliacaoViewModel>();

        public string Erro
        {
            get
            {
                if (Opcoes == null || Opcoes.Count < 4) { 
                    return "A questão deve ter pelo menos 4 (quatro) opções.";
                }
                if (Questao.Tipo == 1 && Opcao.Verdadeira == true)
                {
                    foreach (OpcaoAvaliacaoViewModel opcao in Opcoes)
                    {
                        if (opcao.Verdadeira)
                        {
                            return ("Já existe uma opcao verdadeira para essa questão!");
                        }
                    }
                }
                return "";

            }
        }
    }
}
