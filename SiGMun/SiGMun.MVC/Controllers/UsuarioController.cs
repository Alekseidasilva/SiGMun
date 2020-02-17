using SiGMun.Helpers.Recursos;
using SiGMun.Helpers.Validacoes;
using SiGMun.MVC.Models.Usuarios;
using System.Web.Mvc;
using System.Web.Security;

namespace SiGMun.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index(UsuarioModelo usuario)
        {
            //usuario.
            //Validar(usuario);
            return View();
        }
       
        public ActionResult Login()
        {
            return View();
        }
      
        [HttpPost]
        public void Inserir(UsuarioModelo usuarioModelo)
        {
          

        }
        private string TrocarSenha(string senha, string confirmarSenha)
        {
            AssertionConcern.AssertArgumentNotNull(senha, Errors.SenhaInvalida);
            AssertionConcern.AssertArgumentNotNull(confirmarSenha, Errors.SenhaInvalida);
            AssertionConcern.AssertArgumentEquals(senha, confirmarSenha, Errors.SenhasNaoCombinam);
            
           return senha = PasswordAssertionConcern.Encrypt(senha).ToString();
        }
        private string RedefinirSenha()
        {
            string senha = "123456";
            senha = PasswordAssertionConcern.Encrypt(senha);
            return senha;
        }
        
        
        void Validar(UsuarioModelo usuarioModel)
        {

            AssertionConcern.AssertArgumentLength(usuarioModel.UsuNomeCompleto, 6, 250, Errors.CampoInvalido);
            EmailAssertionConcern.AssertIsValid(usuarioModel.UsuEmail);
            //AssertionConcern.
        }


    }
}