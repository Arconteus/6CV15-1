using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    internal class Profesor
    {
        public int id_profesor {  get; set; }
        public string num_trabajador { get; set; }
        public string nom_trabajador { get; set; }
        public string apa_trabajador { get; set; }
        public string ama_trabajador { get; set; }
    }
}
