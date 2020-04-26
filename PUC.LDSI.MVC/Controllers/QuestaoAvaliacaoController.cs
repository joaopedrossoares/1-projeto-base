using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Identity.Entities;
using PUC.LDSI.MVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PUC.LDSI.MVC.Controllers
{
    public class QuestaoAvaliacaoController : BaseController
    {
        private readonly IAvaliacaoAppService _avaliacaoAppService;
        private readonly IQuestaoAvaliacaoRepository _questaoAvaliacaoRepository;
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        public QuestaoAvaliacaoController(UserManager<Usuario> user,
                                    IAvaliacaoAppService avaliacaoAppService,
                                    IQuestaoAvaliacaoRepository questaoAvaliacaoRepository,
                                    IAvaliacaoRepository avaliacaoRepository) : base(user)
        {
            _avaliacaoAppService = avaliacaoAppService;
            _questaoAvaliacaoRepository = questaoAvaliacaoRepository;
            _avaliacaoRepository = avaliacaoRepository;
        }

        // GET: QuestaoAvaliacao
        public async Task<IActionResult> Index(int avaliacaoId)
        {
            var result = _avaliacaoRepository.ObterAsync(avaliacaoId);

            var avaliacoes = Mapper.Map<AvaliacaoViewModel>(result.Result);

            return View(avaliacoes);
        }

        // GET: QuestaoAvaliacao/Create
        public IActionResult Create(int avaliacaoId)
        {
            var result = _avaliacaoRepository.ObterAsync(avaliacaoId);

            ViewData["Avaliacao"] = Mapper.Map<AvaliacaoViewModel>(result.Result);

            ViewData["OpcoesTipo"] = ObterOpcoesTipo();

            return View();
        }

        // POST: QuestaoAvaliacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvaliacaoId,Tipo,Enunciado,Id,DataCriacao")] Questao questao)
        {
            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AdicionarQuestaoAvaliacaoAsync(questao.AvaliacaoId, questao.Tipo, questao.Enunciado);

                if (result.Success)
                    return RedirectToAction(nameof(Index), new { avaliacaoId = questao.AvaliacaoId });
                else
                    throw result.Exception;
            }
            return View(questao);
        }

        // GET: QuestaoAvaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _questaoAvaliacaoRepository.ObterAsync(id.Value);

            if (questao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<QuestaoAvaliacaoViewModel>(questao);

            ViewData["OpcoesTipo"] = ObterOpcoesTipo(questao.Tipo);

            return View(viewModel);
        }

        // POST: QuestaoAvaliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvaliacaoId,Tipo,Enunciado,Id,DataCriacao")] Questao questao)
        {
            if (id != questao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _avaliacaoAppService.AlterarQuestaoAvaliacaoAsync(questao.Id, questao.Tipo, questao.Enunciado);

                    if (result.Success)
                        return RedirectToAction(nameof(Index), new { avaliacaoId = questao.AvaliacaoId });
                    else
                        throw result.Exception;
                }
                catch (DbUpdateConcurrencyException)
                {

                }
                return RedirectToAction(nameof(Index), new { avaliacaoId = questao.AvaliacaoId });
            }
            return View(questao);
        }

        // GET: QuestaoAvaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _questaoAvaliacaoRepository.ObterAsync(id.Value);

            if (questao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<QuestaoAvaliacaoViewModel>(questao);

            return View(viewModel);
        }

        // POST: QuestaoAvaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questao = await _questaoAvaliacaoRepository.ObterAsync(id);

            var result = await _avaliacaoAppService.ExcluirQuestaoAvaliacaoAsync(id);

            if (result.Success)
            {
                return RedirectToAction(nameof(Index), new { avaliacaoId = questao.Avaliacao.Id });
            }
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
