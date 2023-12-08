using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    internal class RegistroAsistencia
    {
        public int id_registro { get; set; }
        public int id_grupo_registro { get; set; }
        public string fecha_registro { get; set; }
        public string hora_registro { get; set; }
    }
}
