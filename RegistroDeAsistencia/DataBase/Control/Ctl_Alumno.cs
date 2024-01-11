using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Alumno
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase Alumno, que contiene toda la lista de
         * todos los alumnos dadas de alta.
         * Sintaxis: Ctl_Carrera.GetList()
         * Return Type: List<Alumno>
         **/
        public static List<Alumno> GetList()
        {
            List<Alumno> output = GetListWhere("");
            return output;
        }


        public static List<Alumno> GetList(string extraParameters)
        {
            List<Alumno> output = GetListWhere(extraParameters);
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe un alumno registrad con la
         * boleta dada, en caso contrario, regresara false.
         * Sintaxis: Ctl_Alumno.Contain([alumnoInput])
         * Variables: [alumnoInput] -> Alumno(){boleta=[string]}
         * Return type: bool
         **/
        public static bool Contain(Alumno alumnoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_alumno where boleta = @boleta";
                    command.Parameters.AddWithValue("@boleta", alumnoInput.boleta);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["boleta"].ToString() == alumnoInput.boleta)
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
         * Esta funcion añade un alumno si y solo no esta registrado alguien con esa boleta antes, cuando
         * la adicion es exitosa regresa un valor verdadero, pero si el codigo ya existe no se añadira el
         * mismo codigo dos veces y regresara un valor falso.
         * Sintaxis: Ctl_Alumno.add([alumnoInput])
         * Variables: [alumnoInput] -> Alumno()
         *  {
         *      boleta = [stirng],
         *      nom_alumno = [stirng],
         *      apa_alumno = [stirng],
         *      ama_alumno = [stirng],
         *      carrera_alumno = [int],
         *      escuela_alumno = [int]
         *  }
         * Return type: bool
         **/
        public static bool Add(Alumno alumnoInput)
        {
            bool output = false;
            if (!Contain(alumnoInput))
            {
                output = ForceAdd(alumnoInput);
            }
            return output;
        }

        public static bool Delete(Alumno alumnoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "DELETE FROM ctl_alumno WHERE boleta = @boleta";
                    command.Parameters.AddWithValue("@boleta", alumnoInput.boleta);
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
        private static bool ForceAdd(Alumno alumnoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_alumno 
                        (boleta,nom_alumno,apa_alumno,ama_alumno,carrera_alumno,escuela_alumno) 
                        values 
                        (@boleta,@nom_alumno,@apa_alumno,@ama_alumno,@carrera_alumno,@escuela_alumno)";
                    command.Parameters.AddWithValue("@boleta", alumnoInput.boleta);
                    command.Parameters.AddWithValue("@nom_alumno", alumnoInput.nom_alumno);
                    command.Parameters.AddWithValue("@apa_alumno", alumnoInput.apa_alumno);
                    command.Parameters.AddWithValue("@ama_alumno", alumnoInput.ama_alumno);
                    command.Parameters.AddWithValue("@carrera_alumno", alumnoInput.carrera_alumno);
                    command.Parameters.AddWithValue("@escuela_alumno", alumnoInput.escuela_alumno);
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
        private static List<Alumno> GetListWhere(string extraParameters)
        {
            List<Alumno> output = new List<Alumno>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_alumno "+ extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Alumno()
                            {
                                id_alumno = int.Parse(reader["id_alumno"].ToString()),
                                boleta = reader["boleta"].ToString(),
                                nom_alumno = reader["nom_alumno"].ToString(),
                                apa_alumno = reader["apa_alumno"].ToString(),
                                ama_alumno = reader["ama_alumno"].ToString(),
                                carrera_alumno = int.Parse(reader["carrera_alumno"].ToString()),
                                escuela_alumno = int.Parse(reader["escuela_alumno"].ToString())
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
