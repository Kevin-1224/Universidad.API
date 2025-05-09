using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Certificado
    {
        public int Id { get; set; }
        public string FechaEmision { get; set; }
        public string Estado { get; set; }
        public int IdInscripcion { get; set; }
        public Inscripcion? Inscripcion { get; set; }
    }
}
