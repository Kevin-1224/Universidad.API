using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Tipo { get; set; }

        public List<Sesion> seciones = new List<Sesion>();
        public List<Ponente> ponentes = new List<Ponente>();
        public List<Participante> partisipantes = new List<Participante>();
    }
}
