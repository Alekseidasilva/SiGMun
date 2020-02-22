using SiGMun.MVCPro.Models.Usuarios;

namespace SiGMun.MVCPro.Controllers.Contratos
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
