using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Uirapuru.LojaVirtual.Web.Models;

namespace Uirapuru.LojaVirtual.Web.HTMLHelpers
{
    public static class PaginacaoHelpers
    {
        public static  MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginarUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < paginacao.totalPagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginarUrl(i));
                tag.InnerHtml = i.ToString();

                if (i.Equals(paginacao.pagAtual))
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);
            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}