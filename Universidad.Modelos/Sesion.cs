using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Sesion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string Sala { get; set; }
        public int IdEvento { get; set; }
        public Evento? Evento { get; set; }
    }
}
