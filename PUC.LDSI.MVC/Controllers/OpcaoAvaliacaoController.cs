using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.MVC.Models;
using PUC.LDSI.DataBase;


namespace PUC.LDSI.MVC.Controllers
{
    public class OpcaoAvaliacaoController : BaseController
    {
        private readonly IAvaliacaoAppService _avaliacaoAppService;
        private readonly IOpcaoAvaliacaoRepository _opcaoAvaliacaoRepository;
        private readonly IQuestaoAvaliacaoRepository _questaoAvaliacaoRepository;

        public OpcaoAvaliacaoController(UserManager<Usuario> user,
                                            IAvaliacaoAppService avaliacaoAppService,
                                            IOpcaoAvaliacaoRepository opcaoAvaliacaoRepository,
                                            IQuestaoAvaliacaoRepository questaoAvaliacaoRepository) : base(user)
        {
            _avaliacaoAppService = avaliacaoAppService;
            _opcaoAvaliacaoRepository = opcaoAvaliacaoRepository;
            _questaoAvaliacaoRepository = questaoAvaliacaoRepository;
        }

        // GET: OpcaoAvaliacao
        public async Task<IActionResult> Index(int questaoId)
        {
            var result = _questaoAvaliacaoRepository.ObterAsync(questaoId);
            var questoes = Mapper.Map<QuestaoAvaliacaoViewModel>(result.Result);
            return View(questoes);
        }

        // GET: OpcaoAvaliacao/Create
        public IActionResult Create(int questaoId)
        {
            var result = _questaoAvaliacaoRepository.ObterAsync(questaoId);
            ViewData["Questao"] = Mapper.Map<QuestaoAvaliacaoViewModel>(result.Result);
            ViewData["QuestaoId"] = questaoId;
            return View();
        }

        // POST: OpcaoAvaliacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestaoId,Descricao,Verdadeira,Id,DataCriacao")] OpcaoAvaliacao opcaoAvaliacao)
        {
            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AdicionarOpcaoAvaliacaoAsync(opcaoAvaliacao.QuestaoId, opcaoAvaliacao.Descricao, opcaoAvaliacao.Verdadeira);
                if (result.Success)
                    return RedirectToAction(nameof(Index), new { questaoId = opcaoAvaliacao.QuestaoId });
                else
                {
                    throw result.Exception;
                }
            }
            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _opcaoAvaliacaoRepository.ObterAsync(id.Value);

            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<OpcaoAvaliacaoViewModel>(opcaoAvaliacao);
            var result = _questaoAvaliacaoRepository.ObterAsync(opcaoAvaliacao.QuestaoId);
            ViewData["Questao"] = Mapper.Map<QuestaoAvaliacaoViewModel>(result.Result);
            ViewData["QuestaoId"] = opcaoAvaliacao.QuestaoId;
            return View(viewModel);
        }

        // POST: OpcaoAvaliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestaoId,Descricao,Verdadeira,Id,DataCriacao")] OpcaoAvaliacao opcaoAvaliacao)
        {
            if (id != opcaoAvaliacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AlterarOpcaoAvaliacaoAsync(opcaoAvaliacao.Id, opcaoAvaliacao.Descricao, opcaoAvaliacao.Verdadeira);

                if (result.Success)
                    return RedirectToAction(nameof(Index), new { questaoId = opcaoAvaliacao.QuestaoId });
                else { 
                    throw result.Exception;
                }
            }

            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _opcaoAvaliacaoRepository.ObterAsync(id.Value);
            var result = _questaoAvaliacaoRepository.ObterAsync(opcaoAvaliacao.QuestaoId);
            ViewData["Questao"] = Mapper.Map<QuestaoAvaliacaoViewModel>(result.Result);
            ViewData["QuestaoId"] = opcaoAvaliacao.QuestaoId;

            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<OpcaoAvaliacaoViewModel>(opcaoAvaliacao);
            return View(viewModel);
        }

        // POST: OpcaoAvaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opcaoAvaliacao = await _opcaoAvaliacaoRepository.ObterAsync(id);
            var result = await _avaliacaoAppService.ExcluirOpcaoAvaliacaoAsync(id);

            if (result.Success)
                return RedirectToAction(nameof(Index), new { questaoId = opcaoAvaliacao.QuestaoId });
            else { 
                throw result.Exception;
            }
        }

    }
}