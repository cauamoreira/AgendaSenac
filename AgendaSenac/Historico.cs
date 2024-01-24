using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSenac
{
    public class Historico
    {
        [Key]
        public int Id { get; set; }

        public string Login { get; set; }
        public DateTime DataHora { get; set; }
        public string Alteracao { get; set; }

        public string Detalhes { get; set; }

    }
}

