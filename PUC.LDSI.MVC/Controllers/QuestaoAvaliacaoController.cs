using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.DataBase;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Identity.Entities;
using PUC.LDSI.MVC.Models;

namespace PUC.LDSI.MVC.Controllers
{
    public class QuestaoAvaliacaoController : BaseController
    {

        private readonly IAvaliacaoAppService _avaliacaoAppService;
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly IQuestaoAvaliacaoRepository _questaoRepository;
        //IQuestaoAvaliacaoRepository
        public QuestaoAvaliacaoController(UserManager<Usuario> user,
                                     IAvaliacaoAppService avaliacaoAppService,
                                     IQuestaoAvaliacaoRepository questaoRepository,
                                     IAvaliacaoRepository avaliacaoRepository) : base(user)
        {
            _avaliacaoAppService = avaliacaoAppService;
            _questaoRepository = questaoRepository;
            _avaliacaoRepository = avaliacaoRepository;
        }
        // GET: Avaliacao
        public async Task<IActionResult> Index(int avaliacaoId)
        {
            var result = _avaliacaoRepository.ObterAsync(avaliacaoId);
            var avaliacoes = Mapper.Map<AvaliacaoViewModel>(result.Result);
            return View(avaliacoes);
        }



        // GET: Avaliacao/Create
        public IActionResult Create(int avaliacaoId)
        {
            var result = _avaliacaoRepository.ObterAsync(avaliacaoId);
            ViewData["Avaliacao"] = Mapper.Map<AvaliacaoViewModel>(result.Result);
            ViewData["OpcoesTipo"] = ObterOpcoesTipo();
            return View();
        }

        // POST: Avaliação/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AvaliacaoId,Tipo,Enunciado,Avaliacao,Opcoes")] Questao questaoAvaliacao)
        {
            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AdicionarQuestaoAvaliacaoAsync(questaoAvaliacao.AvaliacaoId, questaoAvaliacao.Tipo, questaoAvaliacao.Enunciado);

                if (result.Success)
                    return RedirectToAction(nameof(Index), new { avaliacaoId = questaoAvaliacao.AvaliacaoId });
                else
                    throw result.Exception;
            }
            return View(questaoAvaliacao);
        }

        // GET: Avaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _questaoRepository.ObterAsync(id.Value);

            if (questao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<QuestaoAvaliacaoViewModel>(questao);
            ViewData["OpcoesTipo"] = ObterOpcoesTipo(questao.Tipo);

            return View(viewModel);
        }

        // POST: Avaliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("Id,AvaliacaoId,Tipo,Enunciado,Avaliacao,Opcoes")] Questao questaoAvaliacao)
        {
            if (id != questaoAvaliacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AlterarQuestaoAvaliacaoAsync(questaoAvaliacao.Id, questaoAvaliacao.Tipo, questaoAvaliacao.Enunciado);

                if (result.Success)
                    return RedirectToAction(nameof(Index), new { avaliacaoId = questaoAvaliacao.AvaliacaoId });
                else
                    throw result.Exception;
            }
            return View(questaoAvaliacao);
        }

        // GET: Avaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = _avaliacaoRepository.ObterAsync(id.Value);


            var questaoAvaliacao = await _questaoRepository.ObterAsync(id.Value);

            if (questaoAvaliacao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<QuestaoAvaliacaoViewModel>(questaoAvaliacao);

            return View(viewModel);
        }

        // POST: Avaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, Questao questaoAvaliacao)
        {
            var result = await _avaliacaoAppService.ExcluirQuestaoAvaliacaoAsync(id);

            if (result.Success)
                return RedirectToAction(nameof(Index), new { avaliacaoId = questaoAvaliacao.AvaliacaoId });
            else
                throw result.Exception;

        }
        private List<SelectListItem> ObterOpcoesTipo(int tipoId = 0)
        {
            return new List<SelectListItem>() {
        new SelectListItem{ Text="Múltipla Escolha", Value = "1", Selected = tipoId == 1 },
        new SelectListItem{ Text="Verdadeiro ou Falso", Value = "2", Selected = tipoId == 2 }
    };
        }
    }
}

