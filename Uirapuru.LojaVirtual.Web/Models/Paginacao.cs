using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uirapuru.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int itensTotal{ get; set; }
        public int itensPorPagina { get; set; }
        public int pagAtual { get; set; }

        public int totalPagina
        {
            get
            {
                return (int)Math.Ceiling((decimal)itensTotal / itensPorPagina);
            }
        }
    }
}