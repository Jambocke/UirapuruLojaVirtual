using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uirapuru.LojaVirtual.Repositorio;

namespace Uirapuru.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio Repositorio;
        public int produtosPorPagina = 3;

        public ActionResult ListaProduto(int pagina = 1)
        {
            Repositorio = new ProdutosRepositorio();

            var Produtos = from r in Repositorio.Produtos
                           .OrderBy(p => p.Descricao)
                           .Skip((pagina - 1) * produtosPorPagina)
                           .Take(produtosPorPagina)
                           select r;
                
            return View(Produtos);
        }
    }
}