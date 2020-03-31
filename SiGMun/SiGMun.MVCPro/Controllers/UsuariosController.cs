using SiGMun.MVCPro.Models;
using SiGMun.MVCPro.Repositorios;
using System.Web.Mvc;

namespace SiGMun.MVCPro.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        UsuarioRep _usuarioRep = new UsuarioRep();

        // GET: Usuarios
        public ActionResult Index()
        {
          var usuarios=_usuarioRep.CarregarTodos();
          
            return View(usuarios);
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

        public ActionResult Alterar(int UsuId)
        {
            var usuario = _usuarioRep.BuscarPorId(UsuId);
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Alterar(UsuarioModel usuario)
        {
            
            return View();
        }

    }
}