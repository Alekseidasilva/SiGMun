using SiGMun.MVC.Models.Usuarios;

namespace SiGMun.MVC.Controllers.Contratos
{
    public  interface IUsuarioVM
    {
        
        UsuarioModelo Login(string UsuEmail, string UsuSenha);

    }
}
