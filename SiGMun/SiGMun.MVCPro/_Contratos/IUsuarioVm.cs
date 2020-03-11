namespace SiGMun.MVCPro._Contratos
{
    public interface IUsuarioVm
    {
        IUsuarioVm Login(string UsuEmail, string UsuSenha);
    }
}