using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Profesor
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase Profesor, que contiene toda la lista de
         * profesores dados de alta.
         * Sintaxis: Ctl_Profesor.GetList()
         * Return Type: List<Profesor>
         **/
        public static List<Profesor> GetList()
        {
            List<Profesor> output = new List<Profesor>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_profesor";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Profesor()
                            {
                                id_profesor = int.Parse(reader["id_profesor"].ToString()),
                                num_trabajador = reader["num_trabajador"].ToString(),
                                nom_profesor = reader["nom_trabajador"].ToString(),
                                apa_profesor = reader["apa_trabajador"].ToString(),
                                ama_profesor = reader["ama_trabajador"].ToString()
                            });
                        }
                    }
                }
            }
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe el profesor, Para verificar
         * la identidad del profesor unicamente se comprueba el numero de trabajador.
         * en caso contrario, regresara false.
         * Sintaxis: Ctl_Materias.Contain([profesorInput])
         * Variables: [profesorInput] -> profesorInput(){nom_carrera=[string]}
         * Return type: bool
         **/
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

        /**
         * Esta funcion añade un profesor si y solo no esta registrado esta antes, cuando la adicion
         * es exitosa regresa un valor verdadero, pero si la materia ya existe no se añadira el
         * mismo profesor (o mas bien el mismo numero de trabajador) dos veces y regresara un valor falso.
         * Sintaxis: Ctl_Materias.add([materia])
         * Variables: [profesorInput] -> Profesor()
         * {
         *      num_trabajador=[string],
         *      nom_profesor=[string],
         *      apa_profesor=[string],
         *      ama_profesor=[string]
         * }
         * Return type: bool
         **/
        public static bool Add(Profesor profesorInput)
        {
            bool output = false;
            if (!Contain(profesorInput))
            {
                output = ForceAdd(profesorInput);
            }
            return output;
        }

        //=============================================================================================================
        // Metodos de busqueda con parametros
        //=============================================================================================================

        /**
         * Esta funcion retorna una lista de Carreas que cumple con la clausula where establecida
         * en los parametros.
         * Sintaxis: Ctl_Profesor.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<Profesor>
         **/
        public static List<Profesor> GetListWhere(string whereClause)
        {
            List<Profesor> output = new List<Profesor>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_profesor where @whereClause";
                    command.Parameters.AddWithValue("@whereClause", whereClause);
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
        //=============================================================================================================
        // Metodos privados
        //=============================================================================================================

        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
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
    }
}
