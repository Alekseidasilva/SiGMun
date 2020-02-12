using SiGMun.Helpers.Recursos;
using SiGMun.Helpers.Validacoes;
using System;

namespace SiGMun.MVC.Models.Usuarios
{
    public class UsuarioModel
    {
       
       
        #region Propriedades
        public int UsuId { get; private set; }
        public string UsuNomeCompleto { get; private set; }
        public string UsuEmail { get; private set; }
        public string UsuSenha { get; private set; }
        public int UsuPerfilId { get; private set; }
        public DateTime UsuDataCadastro { get; private set; }
        public int UsuIdUsuario { get; private set; }
        public bool UsuEstado { get; private set; }       
        #endregion


       


    }
}



