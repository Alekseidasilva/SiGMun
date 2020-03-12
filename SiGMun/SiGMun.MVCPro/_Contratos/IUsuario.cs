using SiGMun.MVCPro.Models;

namespace SiGMun.MVCPro._Contratos
{
    public interface IUsuario
    {
        UsuarioModel BuscarPorEmail(string UsuEmail);
        UsuarioModel BuscarPorId(int UsuId);
        bool Adicionar(UsuarioModel usuarioModelo);
        bool Alterar(UsuarioModel usuarioModelo);
        bool Excluir(UsuarioModel usuarioModelo);
        UsuarioModel Login(UsuarioVm usuarioVm);
    }
}