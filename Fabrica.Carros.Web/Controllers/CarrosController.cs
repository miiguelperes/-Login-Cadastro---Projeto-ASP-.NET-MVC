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
using Fabrica.Carros.Web.ViewModels.Carro;
using Fabrica.Carros.Web.ViewModels.Fabricante;

namespace Fabrica.Carros.Web.Controllers
{
    [Authorize]
    public class CarrosController : Controller
    {
        private IRepositorioGenerico<Carro, long>
            repositorioCarros = new CarrosRepositorio(new CarroDbContext());

        private IRepositorioGenerico<Fabricante, int>
            repositorioFabricantes = new FabricantesRepositorio(new CarroDbContext());

        // GET: Carros
        public ActionResult Index()
        {
            //var Carros = db.Carros.Include(m => m.Fabricante);
            return View(Mapper.Map<List<Carro>,
                        List<CarroIndexViewModels>>(repositorioCarros.Selecionar()));
        }

        // GET: Carros/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carro Carro = repositorioCarros.SelecionarPorId(id.Value);
            if (Carro == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Carro, CarroIndexViewModels>(Carro));
        }

        // GET: Carros/Create
        public ActionResult Create()
        {
            //ViewBag.idFabricante = new SelectList(db.Fabricantes, "Id", "Tipo");
            List<FabricanteIndexViewModel> Fabricantes = Mapper.Map<List<Fabricante>,
                List<FabricanteIndexViewModel>>(repositorioFabricantes.Selecionar());

            SelectList dropDownFabricantes = new SelectList(Fabricantes, "id", "Tipo");
            ViewBag.DropDownFabricantes = dropDownFabricantes;
            return View();
        }

        // POST: Carros/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCarro,NomeCarro,Cor,Tamanho,idFabricante,Ano")] CarroViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Carro Carro = Mapper.Map<CarroViewModel, Carro>(viewModel);
                repositorioCarros.Inserir(Carro);
                return RedirectToAction("Index");
            }

            //ViewBag.idFabricante = new SelectList(db.Fabricantes, "Id", "Tipo", Carro.idFabricante);
            return View(viewModel);
        }

        // GET: Carros/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carro Carro = repositorioCarros.SelecionarPorId(id.Value);
            if (Carro == null)
            {
                return HttpNotFound();
            }
            //ViewBag.idFabricante = new SelectList(db.Fabricantes, "Id", "Tipo", Carro.idFabricante);
            List<FabricanteIndexViewModel> Fabricantes = Mapper.Map<List<Fabricante>,
                List<FabricanteIndexViewModel>>(repositorioFabricantes.Selecionar());

            SelectList dropDownFabricantes = new SelectList(Fabricantes, "id", "Tipo");
            ViewBag.DropDownFabricantes = dropDownFabricantes;
            return View(Mapper.Map<Carro, CarroViewModel>(Carro));
        }

        // POST: Carros/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCarro,NomeCarro,Cor,Tamanho,idFabricante,Ano")] CarroViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Carro Carro = Mapper.Map<CarroViewModel, Carro>(viewModel);
                repositorioCarros.Alterar(Carro);
                return RedirectToAction("Index");
            }
            //ViewBag.idFabricante = new SelectList(db.Fabricantes, "Id", "Tipo", Carro.idFabricante);
            return View(viewModel);
        }

        // GET: Carros/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carro Carro = repositorioCarros.SelecionarPorId(id.Value);
            if (Carro == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Carro, CarroIndexViewModels>(Carro));
        }

        // POST: Carros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            repositorioCarros.ExcluirPorId(id);
            return RedirectToAction("Index");
        }

        
    }
}
