using System.Web.Mvc;
using System.Web.Security;
using SiGMun.MVCPro.Controllers.Repositorios;
using SiGMun.MVCPro.Models;

namespace SiGMun.MVCPro.Controllers
{
    public class ContaController : Controller
    {
        UsuarioVMRepositorio UsuarioVMRep=new UsuarioVMRepositorio();

        // GET: Conta
        public ActionResult Login(string returnUrl)
        {
            var model = new UsuarioVM()
            { ReturnUrl = returnUrl };
            return View(model);            
        }

        [HttpPost]
        public ActionResult Login(UsuarioVM usuario)
        {
            //Verificar se os campos estão nulls
            if (!string.IsNullOrEmpty(usuario.UsuEmail))
            {
                if (!string.IsNullOrEmpty(usuario.UsuSenha))
                {
                    var Encontrado=  UsuarioVMRep.Login(usuario.UsuEmail, usuario.UsuSenha);
                    if (usuario.UsuEmail==Encontrado.UsuEmail)
                    {
                        if (usuario.UsuSenha == Encontrado.UsuSenha)
                        {
                        }
                    }
                    if ( Url.IsLocalUrl(usuario.ReturnUrl))
                    {
                        ValidarEmail(usuario.UsuEmail);
                        usuario.UsuSenha= ValidarSenha(usuario.UsuSenha);
                        UsuarioVMRep.Login(usuario.UsuEmail, usuario.UsuSenha);
                        return Redirect(usuario.ReturnUrl);
                    }
                }
            }
            ModelState.AddModelError("UsuEmail","Email inválido");

            return View();
            //return RedirectToAction("Index", "Home");


        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        string ValidarSenha(string senha)
        {
            //AssertionConcern.AssertArgumentNotNull(senha, Errors.CampoEmBranco);
            //AssertionConcern.AssertArgumentLength(senha, 6, 20, Errors.SenhaInvalida);
            //PasswordAssertionConcern.AssertIsValid(senha);
            // return senha=PasswordAssertionConcern.Encrypt(senha);
            return "";
        }

        void ValidarEmail(string Email)
        {
            //AssertionConcern.AssertArgumentNotNull(Email, Errors.CampoEmBranco);
            //EmailAssertionConcern.AssertIsValid(Email);
        }

    }
}