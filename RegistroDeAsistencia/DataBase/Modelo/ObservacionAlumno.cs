using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    internal class ObservacionAlumno
    {
        public int id_observacionAlumno { get; set; }
        public int id_relacion_observacion { get; set; }
        public string observacion { get; set; }
    }
}
