using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uirapuru.LojaVirtual.Repositorio;

namespace Uirapuru.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepositorio repositorio;

        public ActionResult Index()
        {
            this.repositorio = new ProdutosRepositorio();
            var Produtos = this.repositorio.Produtos.Take(3);
            return View(Produtos);
        }
    }
}