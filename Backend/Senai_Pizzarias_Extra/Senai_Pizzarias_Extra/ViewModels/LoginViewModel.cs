using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Senai_Pizzarias_Extra.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Email necessario para Login")]
        [StringLength(250)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha necessaria para Login")]
        [StringLength(250)]
        public string Senha { get; set; }
    }
}
