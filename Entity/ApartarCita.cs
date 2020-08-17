using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ApartarCita
    {
        public Paciente Paciente { get; set; }
        public Agenda Agenda { get; set; }
        public DateTime FechaCita { get; set; }
        public string Hora { get; set; }

        public string CodigoCita { get; set; }
        public string TipoTratamiento { get; set; }
        public decimal ValorCita { get; set; }
    }
}
