﻿using Sistema_Loja.Models;
using Sistema_Loja.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Loja.Controllers
{
    public class OrdensController : Controller
    {
        private Sistema_LojaContext db = new Sistema_LojaContext();

        // GET: Ordens
        public ActionResult NovaOrdem()
        {
            var ordemView = new OrdemView();
            ordemView.Customizar = new Customizar();
            ordemView.ProdutoOrdem = new List<ProdutoOrdem>();            

            var list = db.Customizars.ToList();            
            list = list.OrderBy(x => x.NomeCompleto).ToList();
            ViewBag.CustomizarId = new SelectList(list, "CustomizarId", "NomeCompleto");
            return View(ordemView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}