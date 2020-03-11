using System.Web.Mvc;
using SiGMun.MVCPro.Models;
using SiGMun.MVCPro.Repositorios;

namespace SiGMun.MVCPro.Controllers
{
    
    public class ContaController : Controller
    {
        UsuarioVmRep usuarioVm=new UsuarioVmRep();

        // GET: Conta
       public ActionResult Login(string returnUrl)
       {
           var model = new UsuarioVm()
               { UsuReturnUrl = returnUrl };
           return View(model);
        }
       [HttpPost]
       public ActionResult Login(UsuarioVm usuario)
       {
           if (ModelState.IsValid)
           {
            var Encontrado=usuarioVm.Login(usuario.UsuEmail, usuario.UsuSenha);
            if (Encontrado.UsuEmail==usuario.UsuEmail && Encontrado.UsuSenha==usuario.UsuSenha)
            {
                
            }

           }
           return View(usuario);
       }
    }
}