using AutoMapper;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.MVC.Models;

namespace PUC.LDSI.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Turma, TurmaViewModel>().ReverseMap();

            CreateMap<OpcaoAvaliacao, OpcaoAvaliacaoViewModel>()
    .ForMember(destino => destino.Questao, opt => opt.MapFrom(OpcaoAvaliacao => OpcaoAvaliacao.Questao.Enunciado))
    .ReverseMap();

            CreateMap<Questao, QuestaoAvaliacaoViewModel>()
    .ForMember(destino => destino.Avaliacao, opt => opt.MapFrom(questao => questao.Avaliacao.Descricao))
    .ReverseMap();

            CreateMap<Avaliacao, AvaliacaoViewModel>()
    .ForMember(destino => destino.Professor, opt => opt.MapFrom(avaliacao => avaliacao.Professor.Nome))
    .ForMember(destino => destino.Questoes, opt => opt.MapFrom(questoes => questoes.Questoes))
    .ReverseMap();
        }
    }
}
