using System.ComponentModel.DataAnnotations;

namespace Curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatoria")]
        public string Senha { get; set; }
    }
}
