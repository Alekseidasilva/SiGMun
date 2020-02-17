using SiGMun.Infra;
using SiGMun.MVC.Models;
using SiGMun.MVC.Models.Usuarios;
using System;
using System.Data;

namespace SiGMun.MVC.Controllers.Repositorios
{
    public class UsuarioVMRepositorio
    {
        private ADOConexao conexao = new ADOConexao();
        public UsuarioModelo Login(string UsuEmail, string UsuSenha)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@Email", UsuEmail);
            conexao.AdicionarParametros("@Senha", UsuSenha);
            DataTable tbUsuario = conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_Login");
            UsuarioModelo usuario = new UsuarioModelo();
            foreach (DataRow linha in tbUsuario.Rows)
            {
                usuario.UsuId = Convert.ToInt32(linha["UsuId"]);
                usuario.UsuNomeCompleto = Convert.ToString(linha["UsuNomeCompleto"]);
                usuario.UsuEmail = Convert.ToString(linha["UsuEmail"]);
                usuario.UsuSenha = Convert.ToString(linha["UsuSenha"]);
                usuario.UsuDataCadastro = Convert.ToDateTime(linha["UsuDataCadastro"]);
                usuario.UsuEstado = Convert.ToBoolean(linha["UsuEstado"]);
                usuario.UsuIdUsuario = Convert.ToInt32(linha["UsuIdUsuario"]);
                usuario.UsuPerfilId = Convert.ToInt32(linha["UsuPerfilId"]);

            }

            return usuario;
        }
    }
}