using SiGMun.Helpers.Cripto;
using SiGMun.Infra;
using SiGMun.MVCPro._Contratos;
using SiGMun.MVCPro.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace SiGMun.MVCPro.Repositorios
{
    public class UsuarioRep:IUsuario
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
        public UsuarioModel BuscarPorId(int UsuId)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@UsuId",UsuId);
            DataTable tbUsuario = conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_BuscarPorId");
            UsuarioModel usuario = new UsuarioModel();
            foreach (DataRow linha in tbUsuario.Rows)
            {
                usuario.UsuId = Convert.ToInt32(linha["UsuId"]);
                ///descriptografar
                usuario.UsuNomeCompleto = Convert.ToString(linha["UsuNomeCompleto"]);
                usuario.UsuEmail = Criptografar.Desincriptar(Convert.ToString(linha["UsuEmail"]));               
                usuario.UsuDataCadastro = Convert.ToDateTime(linha["UsuDataCadastro"]);
                usuario.UsuEstado = Convert.ToBoolean(linha["UsuEstado"]);
                usuario.UsuIdUsuario = Convert.ToInt32(linha["UsuIdUsuario"]);
                usuario.UsuPerfilId = Convert.ToInt32(linha["UsuPerfilId"]);

            }
            return usuario;
        }

        public bool Adicionar(UsuarioModel usuarioModelo)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@UsuNomeCompleto", usuarioModelo.UsuNomeCompleto);
            //criptografar Usuario e Senha
            conexao.AdicionarParametros("@UsuEmail", Criptografar.Encriptar(usuarioModelo.UsuEmail));
            conexao.AdicionarParametros("@UsuSenha", Criptografar.Encriptar(usuarioModelo.UsuSenha));
            conexao.AdicionarParametros("@UsuPerfilId", usuarioModelo.UsuPerfilId);
            conexao.AdicionarParametros("@UsuDataCadastro", usuarioModelo.UsuDataCadastro);
            conexao.AdicionarParametros("@UsuIdUsuario", usuarioModelo.UsuIdUsuario);
            conexao.AdicionarParametros("@UsuEstado", usuarioModelo.UsuEstado);
            bool res = Convert.ToBoolean(conexao.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Usuario_Inserir"));
            return res;
        }

        public bool Alterar(UsuarioModel usuarioModelo)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@UsuId", usuarioModelo.UsuId);
            conexao.AdicionarParametros("@UsuNomeCompleto", usuarioModelo.UsuNomeCompleto);
            conexao.AdicionarParametros("@UsuEmail", usuarioModelo.UsuEmail);
            conexao.AdicionarParametros("@UsuSenha", usuarioModelo.UsuSenha);           
            conexao.AdicionarParametros("@UsuEstado", usuarioModelo.UsuEstado);
            conexao.AdicionarParametros("@UsuPerfilId", usuarioModelo.UsuPerfilId);
            bool res=Convert.ToBoolean(conexao.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Usuario_Alterar"));
            if(res)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Excluir(UsuarioModel usuarioModelo)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("@UsuId", usuarioModelo.UsuId);
            bool res = Convert.ToBoolean(conexao.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Usuario_Excluir"));
            if (res) 
                return true;            
                else return false;          

        }
        
        public  UsuarioModel Login(string UsuEmail, string UsuSenha)
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

        public List<UsuarioModel> CarregarTodos()
        {
            conexao.LimparParametro();
            DataTable tbUsuario = conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_CarregarTodos");
            List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();
            foreach (DataRow linha in tbUsuario.Rows)
            {
                UsuarioModel usuario = new UsuarioModel();
                usuario.UsuId = Convert.ToInt32(linha["UsuId"]);
                usuario.UsuNomeCompleto = Convert.ToString(linha["UsuNomeCompleto"]);
                usuario.UsuEmail = Criptografar.Desincriptar(Convert.ToString(linha["UsuEmail"]));
                usuario.UsuDataCadastro = Convert.ToDateTime(linha["UsuDataCadastro"]);
                usuario.UsuEstado = Convert.ToBoolean(linha["UsuEstado"]);
                usuario.UsuIdUsuario = Convert.ToInt32(linha["UsuIdUsuario"]);
                usuario.UsuPerfilId = Convert.ToInt32(linha["UsuPerfilId"]);
                listaUsuarios.Add(usuario);
            }
            return listaUsuarios;
        }

        public void ResetarSenha(UsuarioModel usuarioModel, string NovaSenha)
        {            
           var encontrado= Login(usuarioModel.UsuEmail, usuarioModel.UsuSenha);
            if(encontrado.UsuEmail==usuarioModel.UsuEmail
                && encontrado.UsuSenha==usuarioModel.UsuSenha)
            {
                conexao.LimparParametro();
                conexao.AdicionarParametros("@UsuId", usuarioModel.UsuId);
                conexao.AdicionarParametros("@UsuNovaSenha", NovaSenha);
                conexao.ExecutarConsulta(CommandType.StoredProcedure, "SP_Usuario_AlterarSenha");
            }
        }       
    }
}