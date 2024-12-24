using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_vs.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public required string Nome { get; set; }
        public int Telefone { get; set; }
    }
}
