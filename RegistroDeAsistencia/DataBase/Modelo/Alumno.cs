using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    internal class Alumno
    {
        public int id_alumno { get; set; }
        public string boleta { get; set; }
        public string nom_alumno { get; set; }
        public string apa_alumno { get; set; }
        public string ama_alumno { get; set; }
        public int carrera_alumno { get; set; }
        public int escuela_alumno { get; set; }
    }
}
