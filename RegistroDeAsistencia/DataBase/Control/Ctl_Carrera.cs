using RegistroDeAsistencia.DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAsistencia.DataBase.Control
{
    internal class Ctl_Carrera
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
        public static List<Carrera> GetList()
        {
            List<Carrera> output = new List<Carrera>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_carrera";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Carrera()
                            {
                                id_carrera = int.Parse(reader["id_carrera"].ToString()),
                                nom_carrera = reader["nom_carrera"].ToString()
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
        public static bool Contain(Carrera carreraInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_carrera where nom_carrera = @nom_carrera";
                    command.Parameters.AddWithValue("@nom_carrera", carreraInput.nom_carrera);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["nom_carrera"].ToString() == carreraInput.nom_carrera)
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
         * Esta funcion añade una carrera si y solo no esta registrada antes, cuando
         * la adicion es exitosa regresa un valor verdadero, pero si la materia ya existe no se añadira 
         * la misma dos veces y regresara un valor falso.
         * Sintaxis: Ctl_Carrera.add([carreraInput])
         * Variables: [carreraInput] -> Carrera(){nom_materia=[string]}
         * Return type: bool
         **/
        public static bool Add(Carrera carreraInput)
        {
            bool output = false;
            if (!Contain(carreraInput))
            {
                output = ForceAdd(carreraInput);
            }
            return output;
        }

        //=============================================================================================================
        // Metodos de busqueda con parametros
        //=============================================================================================================

        /**
         * Esta funcion retorna una lista de Carrera que cumple con la clausula where establecida
         * en los parametros.
         * Sintaxis: Ctl_Carrera.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<Carrera>
         **/
        public static List<Carrera> GetListWhere(string parameter, string logic, string value)
        {
            List<Carrera> output = new List<Carrera>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_carrera where @parameter @logic @value";
                    command.Parameters.AddWithValue("@parameter", parameter);
                    command.Parameters.AddWithValue("@logic", logic);
                    command.Parameters.AddWithValue("@value", value);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Carrera()
                            {
                                id_carrera = int.Parse(reader["id_carrera"].ToString()),
                                nom_carrera = reader["nom_carrera"].ToString()
                            });
                        }
                    }
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
        private static bool ForceAdd(Carrera carreraInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_carrera (nom_carrera) values (@nom_carrera)";
                    command.Parameters.AddWithValue("@nom_carrera", carreraInput.nom_carrera);
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
