using SiGMun.Helpers.Recursos;
using SiGMun.Helpers.Validacoes;
using SiGMun.MVC.Controllers.Repositorios;
using SiGMun.MVC.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace SiGMun.MVC.Controllers
{
    public class ContaController : Controller
    {
        UsuarioVMRepositorio UsuarioVMRep=new UsuarioVMRepositorio();

        // GET: Conta
        public ActionResult Login(string returnUrl)
        {
            var model = new UsuarioVM() { ReturnUrl = returnUrl };
            return View(model);
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuarioVM usuario)
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(usuario.UsuEmail, usuario.PermanecerLogado);
                if ( Url.IsLocalUrl(usuario.ReturnUrl))
                {
                    ValidarEmail(usuario.UsuEmail);
                   usuario.UsuSenha= ValidarSenha(usuario.UsuSenha);
                    UsuarioVMRep.Login(usuario.UsuEmail, usuario.UsuSenha);
                    return Redirect(usuario.ReturnUrl);
                }

            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        string ValidarSenha(string senha)
        {
            AssertionConcern.AssertArgumentNotNull(senha, Errors.CampoEmBranco);
            AssertionConcern.AssertArgumentLength(senha, 6, 20, Errors.SenhaInvalida);
            PasswordAssertionConcern.AssertIsValid(senha);
           return senha=PasswordAssertionConcern.Encrypt(senha);
            
        }

        void ValidarEmail(string Email)
        {
            AssertionConcern.AssertArgumentNotNull(Email, Errors.CampoEmBranco);
            EmailAssertionConcern.AssertIsValid(Email);
        }

    }
}