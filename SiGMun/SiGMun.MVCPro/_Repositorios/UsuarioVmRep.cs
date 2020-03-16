using System;
using System.Data;
using SiGMun.Helpers.Validacoes;
using SiGMun.Infra;
using SiGMun.MVCPro._Contratos;
using SiGMun.MVCPro.Models;

namespace SiGMun.MVCPro.Repositorios
{
    public class UsuarioVmRep:IUsuario
    {
        private ADOConexao conexao = new ADOConexao();
      

        public UsuarioModel BuscarPorEmail(string UsuEmail)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@UsuEmail", UsuEmail);
            DataTable tbUsuario = conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_BuscarPorEmail");
            UsuarioModel usuario = new UsuarioModel();
            foreach (DataRow linha in tbUsuario.Rows)
            {
                usuario.UsuEmail = Convert.ToString(linha["UsuEmail"]);
            }
          
            return usuario;

        }

        public UsuarioModel BuscarPorId(int UsuId)
        {
            throw new NotImplementedException();
        }

        public bool Adicionar(UsuarioModel usuarioModelo)
        {
            throw new NotImplementedException();
        }

        public bool Alterar(UsuarioModel usuarioModelo)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(UsuarioModel usuarioModelo)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel Login(UsuarioVm usuarioVm)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@Email", usuarioVm.UsuEmail);
            conexao.AdicionarParametros("@Senha", usuarioVm.UsuSenha);
            DataTable tbUsuario = conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_Login");
            UsuarioModel usuario = new UsuarioModel();
            foreach (DataRow linha in tbUsuario.Rows)
            {
                usuario.UsuId = Convert.ToInt32(linha["UsuId"]);
                usuario.UsuNomeCompleto = Convert.ToString(linha["UsuNomeCompleto"]);
                usuario.UsuEmail = Convert.ToString(linha["UsuEmail"]);
                usuario.UsuSenha =PasswordAssertionConcern.Encrypt(Convert.ToString(linha["UsuSenha"]));
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