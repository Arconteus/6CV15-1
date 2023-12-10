﻿using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public static class Ctl_CodigoGrupo
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
         * codigos de grupo dados de alta.
         * Sintaxis: Ctl_CodigoGrupo.GetList()
         * Return Type: List<CodigoGrupo>
         **/
        public static List<CodigoGrupo> GetList()
        {
            List<CodigoGrupo> output = new List<CodigoGrupo>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_codigoGrupo";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new CodigoGrupo()
                            {
                                id_codigo = int.Parse(reader["id_codigo"].ToString()),
                                desc_grupo = reader["desc_grupo"].ToString()
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
        public static bool Contain(CodigoGrupo codigoGrupoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_codigoGrupo where desc_grupo = @desc_grupo";
                    command.Parameters.AddWithValue("@desc_grupo", codigoGrupoInput.desc_grupo);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["desc_grupo"].ToString() == codigoGrupoInput.desc_grupo)
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
         * Esta funcion añade un codigo de grupo si y solo no esta registrado este codigo antes, cuando
         * la adicion es exitosa regresa un valor verdadero, pero si el codigo ya existe no se añadira el
         * mismo codigo dos veces y regresara un valor falso.
         * Sintaxis: Ctl_CodigoGrupo.add([CodigoGrupo])
         * Variables: [CodigoGrupo] -> CodigoGrupo(){codigo_grupo=[string]}
         * Return type: bool
         **/
        public static bool Add(CodigoGrupo codigoGrupoInput)
        {
            bool output = false;
            if (!Contain(codigoGrupoInput))
            {
                output = ForceAdd(codigoGrupoInput);
            }
            return output;
        }

        //=============================================================================================================
        // Metodos de busqueda con parametros
        //=============================================================================================================

        /**
         * Esta funcion retorna una lista de CodigoGrupo que cumple con la clausula where establecida
         * en los parametros.
         * Sintaxis: Ctl_CodigoGrupo.getListWhere([parameter],[value])
         * Variables: [parameter] -> string, [value] -> string
         * Return type: List<CodigoGrupo>
         **/
        public static List<CodigoGrupo> GetListWhere(string whereClause)
        {
            List<CodigoGrupo> output = new List<CodigoGrupo>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_codigoGrupo where @whereClausee";
                    command.Parameters.AddWithValue("@whereClause", whereClause);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new CodigoGrupo()
                            {
                                id_codigo = int.Parse(reader["id_codigo"].ToString()),
                                desc_grupo = reader["desc_grupo"].ToString()
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
        private static bool ForceAdd(CodigoGrupo codigoGrupoInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_codigoGrupo (desc_grupo) values (@codigo_grupo)";
                    command.Parameters.AddWithValue("@codigo_grupo", codigoGrupoInput.desc_grupo);
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
