using SiGMun.Helpers.Recursos;
using SiGMun.Helpers.Validacoes;
using SiGMun.MVC.Models.Usuarios;
using System.Web.Mvc;

namespace SiGMun.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index(UsuarioModel usuario)
        {
            //usuario.
            //Validar(usuario);
            return View("Teste");
        }

        public ActionResult Login(string email,string senha)
        {
            return View();
        }
        [HttpPost]
        public void Inserir(UsuarioModel usuarioModelo)
        {
            

        }
        private string TrocarSenha(string senha, string confirmarSenha)
        {
            AssertionConcern.AssertArgumentNotNull(senha, Errors.SenhaInvalida);
            AssertionConcern.AssertArgumentNotNull(confirmarSenha, Errors.SenhaInvalida);
            AssertionConcern.AssertArgumentEquals(senha, confirmarSenha, Errors.SenhasNaoCombinam);
            AssertionConcern.AssertArgumentLength(senha, 6, 20, Errors.SenhaInvalida);
           return senha = PasswordAssertionConcern.Encrypt(senha).ToString();
        }
        private string RedefinirSenha()
        {
            string senha = "123456";
            senha = PasswordAssertionConcern.Encrypt(senha);
            return senha;
        }
        
        
        void Validar(UsuarioModel usuarioModel)
        {

            AssertionConcern.AssertArgumentLength(usuarioModel.UsuNomeCompleto, 6, 250, Errors.CampoInvalido);
            EmailAssertionConcern.AssertIsValid(usuarioModel.UsuEmail);
            //AssertionConcern.
        }


    }
}