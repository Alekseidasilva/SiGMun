using System;
using System.Data;
using SiGMun.MVCPro.Controllers.Contratos;
using SiGMun.MVCPro.Models.Usuarios;

namespace SiGMun.MVCPro.Controllers.Repositorios
{
    public class UsuarioRepositorio:IUsuario
    {
        private ADOConexao conexao =new ADOConexao();

        
        public UsuarioModelo BuscarPorEmail(string UsuEmail)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@UsuEmail", UsuEmail);
            DataTable tbusuario = conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_BuscarPorEmail");
            var usuarioModelo = new UsuarioModelo();
            foreach (DataRow linha in tbusuario.Rows)
            {

                usuarioModelo.UsuEmail = Convert.ToString(linha["UsuEmail"]);

            }
            return usuarioModelo;
        }

        public UsuarioModelo BuscarPorId(int UsuId)
        {
            throw new NotImplementedException();
        }

        public bool Adicionar(UsuarioModelo usuarioModelo)
        {
            throw new NotImplementedException();
        }

        public bool Alterar(UsuarioModelo usuarioModelo)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(UsuarioModelo usuarioModelo)
        {
            throw new NotImplementedException();
        }

       
    }
}