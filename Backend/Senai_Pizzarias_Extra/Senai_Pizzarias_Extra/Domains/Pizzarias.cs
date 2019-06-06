using System;
using System.Collections.Generic;

namespace Senai_Pizzarias_Extra.Domains
{
    public partial class Pizzarias
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Isvegan { get; set; }
        public int Categoria { get; set; }
        public string Endereco { get; set; }
        public string TelefoneComercial { get; set; }
    }
}
