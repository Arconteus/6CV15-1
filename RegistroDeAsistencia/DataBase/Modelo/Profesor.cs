﻿namespace RegistroDeAsistencia.DataBase.Modelo
{
    public class Profesor
    {
        internal int id;

        public int id_profesor { get; set; }
        public string num_trabajador { get; set; }
        public string nom_profesor { get; set; }
        public string apa_profesor { get; set; }
        public string ama_profesor { get; set; }
        public string NombreCompleto
        {
            get { return $"{apa_profesor} {ama_profesor} {nom_profesor}"; }
        }
    }
}
