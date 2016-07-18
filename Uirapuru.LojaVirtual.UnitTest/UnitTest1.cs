using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uirapuru.LojaVirtual.Web.HTMLHelpers;

namespace Uirapuru.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarSeAPaginaEstaGerandoCorretamente()
        {
            //Arrange
            System.Web.Mvc.HtmlHelper html = null;

            Uirapuru.LojaVirtual.Web.Models.Paginacao paginacao = new Uirapuru.LojaVirtual.Web.Models.Paginacao
            {
                pagAtual = 2,
                itensPorPagina = 10,
                itensTotal = 28
            };


            Func<int, string> paginarUrl = i => "Pagina" + i;

            //Act
            System.Web.Mvc.MvcHtmlString resultado = html.PageLinks(paginacao, paginarUrl);


            //Assert
            Assert.AreEqual(
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
                           );

        }
    }
}
