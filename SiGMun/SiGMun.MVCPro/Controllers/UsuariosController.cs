using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiGMun.MVCPro.Models;
using SiGMun.MVCPro.Repositorios;

namespace SiGMun.MVCPro.Controllers
{
    //[Authorize]
    public class UsuariosController : Controller
    {
        UsuarioRep _usuarioRep = new UsuarioRep();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Adicionar()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Adicionar(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
              bool estado=_usuarioRep.Adicionar(usuarioModel);
            }
            return View("Index");
        }

    }
}