using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Udemy.Models
{
    public class Usuario
    {

        [Required (ErrorMessage = "O nome é obrigatorio")]
        public string Nome { get; set; }
       // [StringLength(50 , MinimumLength = 5 , ErrorMessage = "")]
        public string Observacoes { get; set; }
        [Range(18,80 , ErrorMessage = "Idade inválida ( minimo 18 e máximo 80)")]
        [Required(ErrorMessage = "A Idade é obrigatoria")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        [Required(ErrorMessage = "O Email é obrigatorio")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage="Login inválido")]
        [Required(ErrorMessage = "O Login é obrigatorio")]
        [Remote("LoginUnico", "Usuario", ErrorMessage="Login já existente")]
        public string Login { get; set; }
        [StringLength(15, MinimumLength = 6, ErrorMessage = "A senha deve conter no minimo 6 caracteres")]
        [Required(ErrorMessage = "A Senha é obrigatoria")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha" , ErrorMessage="As senhas são diferentes")]
        public string ConfirmaraSenha { get; set; }
    }
}

/* if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatorio");
            }

            if (usuario.Senha != usuario.ConfirmaraSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes");
            }*/