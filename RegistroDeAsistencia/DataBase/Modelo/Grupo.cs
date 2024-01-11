namespace RegistroDeAsistencia.DataBase.Modelo
{
    public class Grupo
    {
        public int id_grupo { get; set; }
        public int codigo_grupo { get; set; } // Es una id
        public int anio { get; set; }
        public int periodo { get; set; }
        public int id_materia_grupo { get; set; }
        public int id_profesor_grupo { get; set; }
    }
}
