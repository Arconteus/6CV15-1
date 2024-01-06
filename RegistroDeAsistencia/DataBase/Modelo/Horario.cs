using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;

namespace RegistroDeAsistencia.DataBase.Modelo
{
    public class Horario
    {
        public int id_horario { get; set; }
        public string grupo_horario { get; set; }
        public int hora_horario { get; set; }
        public int dia_horario { get; set; }
    }
}
