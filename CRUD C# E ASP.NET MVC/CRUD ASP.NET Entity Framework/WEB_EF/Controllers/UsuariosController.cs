﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_EF.Conexao;
using WEB_EF.Models;

namespace WEB_EF.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Usuarios()
        {
            var usuario = new UsuarioRepositorioEF();
            var listaUsuarios = usuario.Select();
            return View(listaUsuarios);
        }

        public ActionResult Editar(int id)
        {
            var usuarioAplicacao = new UsuarioRepositorioEF();
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
                var usuarioAplicacao = new UsuarioRepositorioEF();
                usuarioAplicacao.Salvar(usuarios);
                return RedirectToAction("Usuarios", "Usuarios");
            }
            return View(usuarios);
        }

        public ActionResult Detalhes(int id)
        {
            var usuarioAplicacao = new UsuarioRepositorioEF();
            var usuario = usuarioAplicacao.SelectById(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        public ActionResult Excluir(int id)
        {
            var usuarioAplicacao = new UsuarioRepositorioEF();
            var usuario = usuarioAplicacao.SelectById(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmar(Usuarios usuarios)
        {
            var usuarioAplicacao = new UsuarioRepositorioEF();
            usuarioAplicacao.Delete(usuarios);
            return RedirectToAction("Usuarios", "Usuarios");
        }
    }
}