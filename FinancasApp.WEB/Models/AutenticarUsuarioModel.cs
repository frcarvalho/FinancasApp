﻿using System.ComponentModel.DataAnnotations;

namespace FinancasApp.WEB.Models
{
    public class AutenticarUsuarioModel
    {
        [EmailAddress(ErrorMessage ="Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do usuário.")]
        public string? Email { get; set; }

        [MinLength(8, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage ="Por favor, informe a senha do usuário")]
        public string? Senha { get; set; }
    }
}
