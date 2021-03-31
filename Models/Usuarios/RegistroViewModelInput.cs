using System.ComponentModel.DataAnnotations;

namespace Curso.api.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "A Email é obrigatório")]
        public string Email { get; set; }
    }
}
