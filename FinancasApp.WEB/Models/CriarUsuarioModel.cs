﻿using System.ComponentModel.DataAnnotations;

namespace FinancasApp.WEB.Models
{
    public class CriarUsuarioModel
    {
        [MinLength(8, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage ="Por favor, informe o nome do usuário.")]
        public string? Nome { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do usuário.")]
        public string? Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$",
            ErrorMessage ="Por favor, informe a senha com letras minúsculas, maiúsculas e no mínimo 8 caracteres.")]
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a senha do usuário.")]
        public string? Senha { get; set; }

        [Compare("Senha", ErrorMessage ="Senhas não conferem, por favor verifique.")]
        [Required(ErrorMessage ="Por favor, confirme a sua senha.")]
        public string? SenhaConfirmacao { get; set; }

    }
}
