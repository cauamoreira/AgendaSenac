using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSenac
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Login { get; set; }

        [StringLength(50)]
        public string? Cpf { get; set; }

        public DateTime DataNascimento { get; set; }
        [Required]
        [StringLength(50)]
        public string Senha { get; set; }
        public bool Administrador { get; set; }
        public bool Ativo { get; set; }
    }
}

