using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.MVC.AutoMapper;
using PUC.LDSI.MVC.Models;

namespace PUC.LDSI.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Turma, TurmaViewModel>().ReverseMap();

            CreateMap<OpcaoAvaliacao, OpcaoAvaliacaoViewModel>().ReverseMap();
            CreateMap<QuestaoAvaliacao, QuestaoAvaliacaoViewModel>().ReverseMap();
            CreateMap<Avaliacao, AvaliacaoViewModel>()
    .ForMember(destino => destino.Professor, opt => opt.MapFrom(avaliacao => avaliacao.Professor.Nome))
    .ReverseMap();
        }
    }
}
