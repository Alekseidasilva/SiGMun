using System.Web.Mvc;
using System.Web.Security;
using SiGMun.Helpers.Cripto;
using SiGMun.MVCPro.Models;
using SiGMun.MVCPro.Repositorios;

namespace SiGMun.MVCPro.Controllers
{
    
    public class ContaController : Controller
    {
        UsuarioRep _usuarioRep=new UsuarioRep();

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
           usuario.UsuEmail = Criptografar.Encriptar(usuario.UsuEmail);
           usuario.UsuSenha = Criptografar.Encriptar(usuario.UsuSenha);
           if (ModelState.IsValid)
           {
               var Encontrado = _usuarioRep.Login(usuario.UsuEmail, usuario.UsuSenha);
                if (Encontrado != null && (Encontrado.UsuEmail == usuario.UsuEmail && Encontrado.UsuSenha == usuario.UsuSenha))
                {
                    usuario.UsuEmail = Decriptografar.Desincriptar(usuario.UsuEmail);
                    FormsAuthentication.SetAuthCookie(usuario.UsuEmail, usuario.UsuPermanecerLogado);//Autenticar 
                    if (!string.IsNullOrEmpty(usuario.UsuReturnUrl) && Url.IsLocalUrl(usuario.UsuReturnUrl))
                    {
                        return Redirect(usuario.UsuReturnUrl);//Retornar pra o local desejado
                    }
                    return RedirectToAction("Dashboard", "Home");
                }
           }
            return View(usuario);
        }

       public ActionResult Sair()
       {
            FormsAuthentication.SignOut();
          return  RedirectToAction("Login");
          
       }
    }
}