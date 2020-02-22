using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGMun.MVC.Models
{
    public class UsuarioVM
    {
        [Required(ErrorMessage = "O {0} é Obrigatório")]
        //[StringLength(40, ErrorMessage = "o Limite {0]é de {1} caracteres")]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email Inválido")]
        public string UsuEmail { get; set; }
        //[Required(ErrorMessage = "A {0} é obrigatório")]
        //[StringLength(40, ErrorMessage = "o Limite {0]é de {1} caracteres"), MinLength(8), MaxLength(20)]
        public string UsuSenha { get; set; }
        public bool PermanecerLogado { get; set; }
        public string ReturnUrl { get; set; }

    }
}