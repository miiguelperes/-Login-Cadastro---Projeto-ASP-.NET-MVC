using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Fabrica.Carros.Dados.Entity.Context;
using Fabrica.Carros.Dominio;
using Fabrica.Carros.Repositorios.Comum;
using Fabrica.Carros.Repositorios.Entity;
using Fabrica.Carros.Web.Filtros;
using Fabrica.Carros.Web.ViewModels.Fabricante;

namespace Fabrica.Carros.Web.Controllers
{
    [Authorize]
    public class FabricantesController : Controller
    {
        private IRepositorioGenerico<Fabricante, int>
            repositorioFabricantes = new FabricantesRepositorio(new CarroDbContext());

        // GET: Fabricantes

        [LogActionFilter]
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Fabricante>, List<FabricanteIndexViewModel>>(repositorioFabricantes.Selecionar()));
        }

        public ActionResult FiltrarPorNome(string pesquisa)
        {
            List<Fabricante> Fabricantes = repositorioFabricantes
                .Selecionar()
                .Where(t => t.Tipo.Contains(pesquisa)).ToList();
            List<FabricanteIndexViewModel> viewModels = Mapper
                .Map<List<Fabricante>, List<FabricanteIndexViewModel>>(Fabricantes);

            return Json(viewModels, JsonRequestBehavior.AllowGet);
        }

        // GET: Fabricantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante Fabricante = repositorioFabricantes.SelecionarPorId(id.Value);
            if (Fabricante == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Fabricante, FabricanteIndexViewModel>(Fabricante));
        }

        // GET: Fabricantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fabricantes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Composicao,Caracteristica,Fornecedor,Email")] FabricanteViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Fabricante Fabricante = Mapper.Map<FabricanteViewModel, Fabricante>(viewModel);
                repositorioFabricantes.Inserir(Fabricante);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Fabricantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante Fabricante = repositorioFabricantes.SelecionarPorId(id.Value);
            if (Fabricante == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Fabricante, FabricanteIndexViewModel>(Fabricante));
        }

        // POST: Fabricantes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Composicao,Caracteristica,Fornecedor,Email")] FabricanteViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Fabricante Fabricante = Mapper.Map<FabricanteViewModel, Fabricante>(viewModel);
                repositorioFabricantes.Alterar(Fabricante);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Fabricantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante Fabricante = repositorioFabricantes.SelecionarPorId(id.Value);
            if (Fabricante == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Fabricante, FabricanteIndexViewModel>(Fabricante));
        }

        // POST: Fabricantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioFabricantes.ExcluirPorId(id);
            return RedirectToAction("Index");
        }

    }
}
