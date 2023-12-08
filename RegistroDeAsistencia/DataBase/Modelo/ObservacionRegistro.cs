using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    internal class ObservacionRegistro
    {
        public int id_observacionRegistro { get; set; }
        public int id_registro_observacion { get; set; }
        public string observacion { get; set; }
    }
}
