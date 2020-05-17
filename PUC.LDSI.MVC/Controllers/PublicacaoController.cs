using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Policy = "Professor")]
    public class PublicacaoController : BaseController
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;
        private readonly ITurmaRepository _turmaRepository;

        private readonly IAvaliacaoAppService _avaliacaoAppService;
        private readonly IPublicacaoRepository _publicacaoRepository;
        

        public PublicacaoController(UserManager<Usuario> user,
                                        IAvaliacaoAppService avaliacaoAppService,
                                        IPublicacaoRepository publicacaoRepository,
                                        IAvaliacaoRepository avaliacaoRepository,
                                        ITurmaRepository turmaRepository) : base(user)
        {
            _avaliacaoRepository = avaliacaoRepository;
            _turmaRepository = turmaRepository;

            _avaliacaoAppService = avaliacaoAppService;
            _publicacaoRepository = publicacaoRepository;
        }
        #region GET
        // GET: Publicacao
        public async Task<IActionResult> Index()
        {
            //para listar as avaliações de cada professor
            var result = _publicacaoRepository.ListarAvaliacoesDoProfessorAsync(UsuarioLogado.IntegrationId);
            var publi = Mapper.Map<List<PublicacaoViewModel>>(result.Result);
            return View(publi);
        }

        // GET: Publicacao/Create
        public IActionResult Create()
        {
            ViewData["Avaliacoes"] = ObterAvaliacoes(); 
            ViewData["Turmas"] = new SelectList(_turmaRepository.ObterTodos().ToList(), "Id", "Nome"); //listada por id/nome
            return View();
        }
        // GET: Publicacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //id nulo
            if (id == null)
            {
                return NotFound();
            }
            //instacia a publicacao
            var publicacao = await _publicacaoRepository.ObterAsync(id.Value);

            //se publicação for nulo
            if (publicacao == null)
            {
                return NotFound();
            }
            //mapenado view e retornando
            var viewModel = Mapper.Map<PublicacaoViewModel>(publicacao);
            return View(viewModel);
        }
        // GET: Publicacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var publicacao = await _publicacaoRepository.ObterAsync(id.Value);

            if (publicacao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<PublicacaoViewModel>(publicacao);
            return View(viewModel);
        }
        #endregion GET
        #region POST
        // POST: Publicacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvaliacaoId,TurmaId,DataInicio,DataFim,ValorProva,Id,DataCriacao")] Publicacao publicacao)
        {

            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AdicionarPublicacaoAsync(UsuarioLogado.IntegrationId, publicacao.AvaliacaoId, publicacao.TurmaId, publicacao.DataInicio, publicacao.DataFim, publicacao.ValorProva);

                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    throw result.Exception;
                }
            }
            return View(publicacao);
        }
        // POST: Publicacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvaliacaoId,TurmaId,DataInicio,DataFim,ValorProva,Id,DataCriacao")] Publicacao publicacao)
        {
            if (id != publicacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AlterarPublicacaoAsync(UsuarioLogado.IntegrationId, publicacao.Id, publicacao.DataInicio, publicacao.DataFim, publicacao.ValorProva);

                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else 
                { 
                    throw result.Exception;
                }
            }
            return View(publicacao);
        }
        // POST: Publicacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _avaliacaoAppService.ExcluirPublicacaoAsync(UsuarioLogado.IntegrationId, id);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                throw result.Exception;
            }
        }
        #endregion POST
        #region Met
        public List<SelectListItem> ObterAvaliacoes()
        {
            var ava = _avaliacaoRepository.ListarAvaliacoesDoProfessorAsync(UsuarioLogado.IntegrationId).Result;
            List<SelectListItem> listAvaliacoes = new List<SelectListItem>();
            foreach (var i in ava)
            {
                listAvaliacoes.Add(new SelectListItem { Text = i.Disciplina + " - " + i.Materia + " - " + i.Descricao, Value = i.Id.ToString() });
            }
            return listAvaliacoes;
        }
        #endregion Met
    }
}
