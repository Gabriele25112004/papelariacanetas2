using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace papelariacanetas2.Models
{
    public class Cadastro
    {
        public int Id { get; set; }

        [Column(TypeName = "TEXT")]
        public string Nome { get; set; }
        [Column(TypeName = "TEXT")]
        public string Login { get; set; }
        [Column(TypeName = "TEXT")]
        public string Senha { get; set; }
        [Column(TypeName = "TEXT")]
        public string Email { get; set; }
    }
}