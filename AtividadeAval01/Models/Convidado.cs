using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAval01.Models
{
    public class Convidado
    {
        public int ConvidadoId { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Telefone { get; set; }
        public bool? Comparecimento { get; set; }
    }
}
