using System.ComponentModel.DataAnnotations;

namespace SiGMun.MVCPro.Models
{
    public class UsuarioVm
    {
        [Required(ErrorMessage = "o email é obrigatório")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "email Inválido")]
        public string UsuEmail { get; set; }

        [Required(ErrorMessage = "o campo senha é obrigatório"), StringLength(maximumLength: 20, MinimumLength = 6,ErrorMessage = "a senha deve ter no minimo {2} e no máximo {1} caracteres")]
        public string UsuSenha { get; set; }

        public bool UsuPermanecerLogado { get; set; }
        public string UsuReturnUrl { get; set; }

    }
}