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
    public class Tbl_RelacionRegistroAlumno
    {
        //=============================================================================================================
        // Variables de control de la base de datos
        //=============================================================================================================

        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        //=============================================================================================================
        // Metodos publicos
        //=============================================================================================================

        /**
         * Esta funcion regresa una lista de la clase CodigoGrupo, que contiene toda la lista de
         * la relacion entre el registro y los alumnos.
         * Sintaxis: Tbl_RelacionRegistroAlumno.GetList()
         * Return Type: List<RelacionRegistroAlumno>
         **/
        public static List<RelacionRegistroAlumno> GetList()
        {
            List<RelacionRegistroAlumno> output = new List<RelacionRegistroAlumno>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_relacionRegistroAlumno";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new RelacionRegistroAlumno()
                            {
                                id_relacion = int.Parse(reader["id_relacion"].ToString()),
                                id_registro_relacion = int.Parse(reader["id_registro_relacion"].ToString()),
                                id_alumno_registro = int.Parse(reader["id_alumno_registro"].ToString())
                            });
                        }
                    }
                }
            }
            return output;
        }

        /**
         * Esta funcion regresa un valor verdadero si es que existe una relacion entre el alumno dado
         * y el registro en caso contrario, regresara false.
         * Sintaxis: Tbl_RelacionRegistroAlumno.Contain([relacionRegistroAlumnoInput])
         * Variables: [relacionRegistroAlumnoInput] -> RelacionRegistroAlumno()
         *  {
         *      id_registro_relacion = [int],
         *      id_alumno_registro = [int]
         *  }
         * Return type: bool
         **/
        public static bool Contain(RelacionRegistroAlumno relacionRegistroAlumnoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_relacionRegistroAlumno " +
                        "where id_registro_relacion = @id_registro_relacion " +
                        "and id_alumno_registro = @id_alumno_registro";
                    command.Parameters.AddWithValue("@id_registro_relacion", relacionRegistroAlumnoInput.id_registro_relacion);
                    command.Parameters.AddWithValue("@id_alumno_registro", relacionRegistroAlumnoInput.id_alumno_registro);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output = true;
                        }
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        /**
         * Esta funcion añade una relacion entre un alumno y un registro de asistencia si y solo no esta 
         * registrado este codigo antes, cuando la adicion es exitosa regresa un valor verdadero, pero 
         * si el codigo ya existe no se añadira el  mismo codigo dos veces y regresara un valor falso.
         * Sintaxis: Ctl_CodigoGrupo.add([relacionRegistroAlumnoInput])
         * Variables: [relacionRegistroAlumnoInput] -> RelacionRegistroAlumno()
         *  {
         *      id_registro_relacion = [int],
         *      id_alumno_registro = [int]
         *  }
         * Return type: bool
         **/
        public static bool Add(RelacionRegistroAlumno relacionRegistroAlumnoInput)
        {
            bool output = false;
            if (!Contain(relacionRegistroAlumnoInput))
            {
                output = ForceAdd(relacionRegistroAlumnoInput);
            }
            return output;
        }


        //=============================================================================================================
        // Metodos de busqueda con parametros
        //=============================================================================================================

        /**
         * Esta funcion retorna una lista de RelacionRegistroAlumno que cumple con la clausula where 
         * establecida en los parametros.
         * Sintaxis: Tbl_RelacionRegistroAlumno.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<RelacionRegistroAlumno>
         **/
        public static List<RelacionRegistroAlumno> GetListWhere(string parameter, string logic, string value)
        {
            List<RelacionRegistroAlumno> output = new List<RelacionRegistroAlumno>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from tbl_relacionRegistroAlumno where @parameter @logic @value";
                    command.Parameters.AddWithValue("@parameter", parameter);
                    command.Parameters.AddWithValue("@logic", logic);
                    command.Parameters.AddWithValue("@value", value);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new RelacionRegistroAlumno()
                            {
                                id_relacion = int.Parse(reader["id_relacion"].ToString()),
                                id_registro_relacion = int.Parse(reader["id_registro_relacion"].ToString()),
                                id_alumno_registro = int.Parse(reader["id_alumno_registro"].ToString())
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
        private static bool ForceAdd(RelacionRegistroAlumno relacionRegistroAlumnoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO tbl_relacionRegistroAlumno (id_registro_relacion,id_alumno_registro) 
                        values (@id_registro_relacion,@id_alumno_registro)";
                    command.Parameters.AddWithValue("@id_registro_relacion", relacionRegistroAlumnoInput.id_registro_relacion);
                    command.Parameters.AddWithValue("@id_alumno_registro", relacionRegistroAlumnoInput.id_alumno_registro);
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
