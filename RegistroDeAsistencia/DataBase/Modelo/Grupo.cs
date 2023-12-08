using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    internal class Grupo
    {
        public int id_grupo {  get; set; }
        public int codigo_grupo { get; set; }
        public int anio { get; set; }
        public int periodo { get; set; }
        public int id_materia_grupo { get; set; }
        public int id_profesor_grupo { get; set; }
    }
}
