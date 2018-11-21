using System.ComponentModel.DataAnnotations;

namespace AutenticacaoAspNet.ViewModels
{
    public class AlterarSenhaViewModel
    {
        [Required(ErrorMessage = "Informe sua senha atual")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 5 caracteres")]
        public string SenhaAtual { get; set; }

        [Required(ErrorMessage = "Informe sua nova atual")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova atual")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 5 caracteres")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme sua nova senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar atual")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 5 caracteres")]
        [Compare(nameof(NovaSenha), ErrorMessage = "A senha e a confirmação não estão iguais")]
        public string ConfirmacaoSenha { get; set; }
    }
}