using SiGMun.MVC.Models.Usuarios;

namespace SiGMun.MVC.Controllers.Contratos
{
    public  interface IUsuario
    {
        UsuarioModelo BuscarPorEmail(string UsuEmail);
        UsuarioModelo BuscarPorId(int UsuId);
        bool Adicionar(UsuarioModelo usuarioModelo);
        bool Alterar(UsuarioModelo usuarioModelo);
        bool Excluir(UsuarioModelo usuarioModelo);
     

    }
}
