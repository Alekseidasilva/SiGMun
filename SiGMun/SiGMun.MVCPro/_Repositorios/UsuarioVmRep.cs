using System;
using System.Data;
using SiGMun.Infra;
using SiGMun.MVCPro.Models;

namespace SiGMun.MVCPro.Repositorios
{
    public class UsuarioVmRep
    {
        private ADOConexao conexao = new ADOConexao();
        public UsuarioModel Login(string UsuEmail, string UsuSenha)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@Email", UsuEmail);
            conexao.AdicionarParametros("@Senha", UsuSenha);
            DataTable tbUsuario = conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_Login");
            UsuarioModel usuario = new UsuarioModel();
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