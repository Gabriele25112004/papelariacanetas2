using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace papelariacanetas2.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int ValorUnitario { get; set; }

        [Column(TypeName = "TEXT")]
        public string NomeProduto { get; set; }
        [Column(TypeName = "TEXT")]
        public string TipoProduto { get; set; }

    }
}