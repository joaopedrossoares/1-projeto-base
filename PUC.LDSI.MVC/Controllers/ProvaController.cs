using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.DataBase.Repository;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Identity.Entities;
using PUC.LDSI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.LDSI.MVC.Controllers
{
    [Authorize(Policy = "Aluno")]

    public class ProvaController : BaseController
    {
        private readonly IAvaliacaoAppService _avaliacaoAppService;
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        public ProvaController(UserManager<Usuario> user,
                                  IAvaliacaoAppService avaliacaoAppService,
                                  IAvaliacaoRepository avaliacaoRepository) : base(user)
        {
            _avaliacaoAppService = avaliacaoAppService;

            _avaliacaoRepository = avaliacaoRepository;
        }

        public async Task<IActionResult> Index()
        {
            

            var result = _avaliacaoRepository.ObterTodos();

            var avaliacoes = Mapper.Map<List<AvaliacaoViewModel>>(result.ToList());

            
            return View(avaliacoes);
        }

       
    }
}