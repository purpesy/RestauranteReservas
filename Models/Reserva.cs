using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_vs.Models
{
    internal class Reserva
    {
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public int MesaID {  get; set; }
        public DateTime DataHora { get; set; }
    }
}
