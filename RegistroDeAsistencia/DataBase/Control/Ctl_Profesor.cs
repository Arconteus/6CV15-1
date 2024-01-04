using RegistroDeAsistencia.DataBase.Modelo;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Profesor
    {
        // Variables de control de la base de datos
        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        // Obtiene una lista de todos los profesores
        public static List<Profesor> GetList()
        {
            List<Profesor> output = GetListWhere("");
            return output;
        }

        // Obtiene una lista de profesores con parámetros adicionales
        public static List<Profesor> GetList(string extraParameters)
        {
            List<Profesor> output = GetListWhere(extraParameters);
            return output;
        }

        // Verifica si un profesor ya está registrado usando el número de trabajador
        public static bool Contain(Profesor profesorInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_profesor where num_trabajador = @num_trabajador";
                    command.Parameters.AddWithValue("@num_trabajador", profesorInput.num_trabajador);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["num_trabajador"].ToString() == profesorInput.num_trabajador)
                            {
                                output = true;
                            }
                        }
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        // Añade un profesor si no está registrado
        public static bool Add(Profesor profesorInput)
        {
            bool output = false;
            if (!Contain(profesorInput))
            {
                output = ForceAdd(profesorInput);
            }
            return output;
        }

        // Elimina un profesor según su número de trabajador
        public static bool Delete(string num_trabajador)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "DELETE FROM ctl_profesor WHERE num_trabajador = @num_trabajador";
                    command.Parameters.AddWithValue("@num_trabajador", num_trabajador);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }

                    command.Parameters.Clear();
                }
            }
            return output;
        }

        // Método interno para añadir un profesor a la base de datos
        private static bool ForceAdd(Profesor profesorInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_profesor (num_trabajador,nom_profesor,apa_profesor,ama_profesor) 
                        values (@num_trabajador,@nom_profesor,@apa_profesor,@ama_profesor)";
                    command.Parameters.AddWithValue("@num_trabajador", profesorInput.num_trabajador);
                    command.Parameters.AddWithValue("@nom_profesor", profesorInput.nom_profesor);
                    command.Parameters.AddWithValue("@apa_profesor", profesorInput.apa_profesor);
                    command.Parameters.AddWithValue("@ama_profesor", profesorInput.ama_profesor);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        // Método interno para obtener una lista de profesores con parámetros adicionales
        private static List<Profesor> GetListWhere(string extraParameters)
        {
            List<Profesor> output = new List<Profesor>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_profesor " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Profesor()
                            {
                                id_profesor = int.Parse(reader["id_profesor"].ToString()),
                                num_trabajador = reader["num_trabajador"].ToString(),
                                nom_profesor = reader["nom_profesor"].ToString(),
                                apa_profesor = reader["apa_profesor"].ToString(),
                                ama_profesor = reader["ama_profesor"].ToString()
                            });
                        }
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }
    }
}
