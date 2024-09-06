using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace matheus.Models
{
    public class Pessoa
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public string CPF { get; set; }

        [Required]
        public bool Ativo {  get; set; }

        [MaxLength(8)]
        [Required]
       // [RAvalidation]

        public string RA {  get; set; }

    }
}
