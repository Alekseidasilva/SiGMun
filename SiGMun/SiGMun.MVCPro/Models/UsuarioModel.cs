using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiGMun.MVCPro.Models
{
    public class UsuarioModel
    {


        #region Propriedades
        public int UsuId { get; set; }
        public string UsuNomeCompleto { get; set; }
        public string UsuEmail { get; set; }
        public string UsuSenha { get; set; }
        public int UsuPerfilId { get; set; }
        public DateTime UsuDataCadastro { get; set; }
        public int UsuIdUsuario { get; set; }
        public bool UsuEstado { get; set; }
        #endregion

    }
}