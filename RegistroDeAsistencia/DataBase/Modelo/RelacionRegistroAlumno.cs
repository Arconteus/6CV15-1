using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    internal class RelacionRegistroAlumno
    {
        public int id_relacion { get; set; }
        public int id_registro_relacion { get; set; }
        public int id_alumno_registro { get; set; }
    }
}
