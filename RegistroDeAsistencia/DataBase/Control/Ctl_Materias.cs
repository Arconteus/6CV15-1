using RegistroDeAsistencia.DataBase.Modelo;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Materias
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================
        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================
        /**
         * Esta funcion regresa una lista de la clase Materia, que contiene toda la lista de
         * Materia dados de alta.
         * Sintaxis: Ctl_Materias.GetList()
         * Return Type: List<Materia>
         **/
        public static List<Materia> GetList()
        {
            return GetListWhere("");
        }

        public static List<Materia> GetList(string extraParameters)
        {
            return GetListWhere(extraParameters);
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe la materia,
         * en caso contrario, regresara false.
         * Sintaxis: Ctl_Materias.Contain([materiaInput])
         * Variables: [materiaInput] -> Materia(){nom_materia=[string]}
         * Return type: bool
         **/
        public static bool Contain(Materia materiaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT * FROM ctl_materias WHERE nom_materia = @nom_materia";
                    command.Parameters.AddWithValue("@nom_materia", materiaInput.nom_materia);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["nom_materia"].ToString() == materiaInput.nom_materia)
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

        /**
         * Esta funcion añade la materia si y solo no esta registrado esta antes, cuando la adicion
         * es exitosa regresa un valor verdadero, pero si la materia ya existe no se añadira la
         * misma materia dos veces y regresara un valor falso.
         * Sintaxis: Ctl_Materias.add([materiaInput])
         * Variables: [materia] -> Materia(){nom_materia=[string]}
         * Return type: bool
         **/
        public static bool Add(Materia materiaInput)
        {
            bool output = false;
            if (!Contain(materiaInput))
            {
                output = ForceAdd(materiaInput);
            }
            return output;
        }

        /**
         * Esta funcion elimina la materia con el id proporcionado.
         * Sintaxis: Ctl_Materias.Delete([idMateria])
         * Variables: [idMateria] -> int
         * Return type: bool
         **/
        public static bool Delete(int idMateria)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DELETE FROM ctl_materias WHERE id_materia = @id_materia";
                    command.Parameters.AddWithValue("@id_materia", idMateria);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        //=============================================================================================================
        // Metodos privados
        //=============================================================================================================
        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
        private static bool ForceAdd(Materia materiaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"INSERT INTO ctl_materias (nom_materia) VALUES (@nom_materia)";
                    command.Parameters.AddWithValue("@nom_materia", materiaInput.nom_materia);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
        private static List<Materia> GetListWhere(string extraParameters)
        {
            List<Materia> output = new List<Materia>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT * FROM ctl_materias " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Materia()
                            {
                                id_materia = int.Parse(reader["id_materia"].ToString()),
                                nom_materia = reader["nom_materia"].ToString()
                            });
                        }
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        internal static bool Delete(Materia materia)
        {
            throw new NotImplementedException();
        }
    }
}
