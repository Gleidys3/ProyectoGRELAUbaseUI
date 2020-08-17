using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Paciente 
    {
        public string Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Genero { get; set; }
        public string Barrio { get; set; }
        public int Calle { get; set; }
       
        public string Ciudad { get; set; }  
    }
}
