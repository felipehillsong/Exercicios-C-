﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB.Conexao;
using WEB.Models;

namespace WEB.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Usuarios()
        {
            var usuario = new UsuarioAplicacao();
            var listaUsuarios = usuario.Select();
            return View(listaUsuarios);
        }

        public ActionResult Editar(int id)
        {
            var usuarioAplicacao = new UsuarioAplicacao();
            var usuario = usuarioAplicacao.SelectById(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Editar(Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                var usuarioAplicacao = new UsuarioAplicacao();
                usuarioAplicacao.Salvar(usuarios);
                return RedirectToAction("Usuarios", "Usuarios");
            }
            return View(usuarios);
        }

        public ActionResult Detalhes(int id)
        {
            var usuarioAplicacao = new UsuarioAplicacao();
            var usuario = usuarioAplicacao.SelectById(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        public ActionResult Excluir(int id)
        {
            var usuarioAplicacao = new UsuarioAplicacao();
            var usuario = usuarioAplicacao.SelectById(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmar(int id)
        {
            var usuarioAplicacao = new UsuarioAplicacao();
            usuarioAplicacao.Delete(id);
            return RedirectToAction("Usuarios", "Usuarios");           
        }
    }
}