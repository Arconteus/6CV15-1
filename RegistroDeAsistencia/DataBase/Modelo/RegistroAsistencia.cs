namespace RegistroDeAsistencia.DataBase.Modelo
{
    public class RegistroAsistencia
    {
        public int id_registro { get; set; }
        public int id_grupo_registro { get; set; }
        public string fecha_registro { get; set; }
        public int id_hora_registro { get; set; }
    }
}
