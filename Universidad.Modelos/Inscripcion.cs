using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public string FechaInscripcion { get; set; }
        public string Estado { get; set; }

        public int IdEvento { get; set; }
        public Evento Evento { get; set; }
        public int IdParticipante { get; set; }
        public Participante? Partisipante { get; set; }
    }
}
