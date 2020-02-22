using SiGMun.MVCPro.Models.Usuarios;

namespace SiGMun.MVCPro.Controllers.Contratos
{
    public  interface IUsuarioVM
    {
        
        UsuarioModelo Login(string UsuEmail, string UsuSenha);

    }
}
