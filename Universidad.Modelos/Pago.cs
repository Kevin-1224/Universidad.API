using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Pago
    {
        public int Id { get; set; }
        public int InscripcionId { get; set; }
        public double Monto { get; set; }
        public string FechaPago { get; set; }
        public string MetodoPago { get; set; }

        public int IdInscripcion { get; set; }
        public Inscripcion? Inscripcion { get; set; }
    }
}
