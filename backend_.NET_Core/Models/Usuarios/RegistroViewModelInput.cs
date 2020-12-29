namespace backend_.NET_Core.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMEssage = "O Login é obrigatório")]

        public string Login { get; set; }

        [Required(ErrorMEssage = "O E-mail é obrigatório")]

        public string Email { get; set; }

        [Required(ErrorMEssage = "A Senha é obrigatória")]

        public string Senha { get; set; }
    }
}