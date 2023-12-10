using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Escuela
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase Carrera, que contiene toda la lista de
         * carreras dadas de alta.
         * Sintaxis: Ctl_Carrera.GetList()
         * Return Type: List<Carrera>
         **/
        public static List<Escuela> GetList()
        {
            List<Escuela> output = new List<Escuela>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_escuela";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Escuela()
                            {
                                id_escuela = int.Parse(reader["id_escuela"].ToString()),
                                nom_escuela = reader["nom_escuela"].ToString()
                            });
                        }
                    }
                }
            }
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe el codigo de grupo,
         * en caso contrario, regresara false.
         * Sintaxis: Ctl_CodigoGrupo.Contain([codigoGrupo])
         * Variables: [codigoGrupoInput] -> CodigoGrupo{desc_grupo=[string]}
         * Return type: bool
         **/
        public static bool Contain(Escuela escuelaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_escuela where nom_escuela = @nom_escuela";
                    command.Parameters.AddWithValue("@nom_escuela", escuelaInput.nom_escuela);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["nom_escuela"].ToString() == escuelaInput.nom_escuela)
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
         * Esta funcion añade una escuela si y solo no esta registrada antes, cuando
         * la adicion es exitosa regresa un valor verdadero, pero si la materia ya existe no se añadira 
         * la misma dos veces y regresara un valor falso.
         * Sintaxis: Ctl_Escuela.add([escuelaInput])
         * Variables: [escuelaInput] -> Escuela(){nom_escuela=[string]}
         * Return type: bool
         **/
        public static bool Add(Escuela escuelaInput)
        {
            bool output = false;
            if (!Contain(escuelaInput))
            {
                output = ForceAdd(escuelaInput);
            }
            return output;
        }

        //=============================================================================================================
        // Metodos de busqueda con parametros
        //=============================================================================================================

        /**
         * Esta funcion retorna una lista de Escuela que cumple con la clausula where establecida
         * en los parametros.
         * Sintaxis: Ctl_Escuela.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<Escuela>
         **/
        public static List<Escuela> GetListWhere(string whereClause)
        {
            List<Escuela> output = new List<Escuela>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_escuela where @whereClause";
                    command.Parameters.AddWithValue("@whereClause", whereClause);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Escuela()
                            {
                                id_escuela = int.Parse(reader["id_escuela"].ToString()),
                                nom_escuela = reader["nom_escuela"].ToString()
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
        private static bool ForceAdd(Escuela escuelaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_escuela (nom_escuela) values (@nom_escuela)";
                    command.Parameters.AddWithValue("@nom_escuela", escuelaInput.nom_escuela);
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
