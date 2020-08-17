using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Agenda
    {
        public string Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public int Telefono { get; set; }
        public string PrimerApellido { get; set; }
        public string CodigoAgenda { get; set; }
        public DateTime Fecha { get; set; }
        public string Jornada { get; set; }
        public DateTime FechaFinal { get; set; }
    }
}
