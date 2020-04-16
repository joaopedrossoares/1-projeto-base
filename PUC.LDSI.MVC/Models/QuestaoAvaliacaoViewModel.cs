using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PUC.LDSI.MVC.Models
{
    public class QuestaoAvaliacaoViewModel
    {
        [Key]
        public int Id { get; set; }

        public int AvaliacaoId { get; set; }

        [Required(ErrorMessage = "O Tipo é requerido.")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "O Enunciado é requerido.")]
        [MaxLength(225, ErrorMessage = "Informe no maximo {0} caracteres.")]
        public string Enunciado { get; set; }

        public AvaliacaoViewModel Avaliacao { get; set; }

        public List<OpcaoAvaliacaoViewModel> OpcaoAvaliacao { get; set; }

        /* TODO Conterá uma lógica de validação da opção da avaliação;
Se tiver erro na validação seu texto será a descrição do erro ou pendência.
Se tiver menos de 4 opções o texto deve ser "A questão deve ter pelo menos 4 (quatro) opções."
Se for questão de multipla escolha e não tiver nenhuma opção verdadeira: "A questão deve ter pelo menos 1 (uma) opção verdadeira."
Qualquer outro caso o texto será uma string vazia.*/
        public string Erro { get; set; }
    }
}
