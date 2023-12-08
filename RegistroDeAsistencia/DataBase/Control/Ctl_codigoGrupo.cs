﻿using RegistroDeAsistencia.DataBase.Modelo;
using System.Data.SQLite;
using System.Configuration;

namespace RegistroDeAsistencia.DataBase.Control
{
    public static class Ctl_codigoGrupo
    {
        //==============================================
        // Variables de control de la base de datos
        //==============================================
        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        //==============================================
        // Metodos de ctl_CodigoGrupo
        //==============================================
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
         * Sintaxis: Ctl_codigoGrupo.Contain([codigoGrupo])
         * Variables: [codigoGrupo] -> string
         * Return type: bool
         **/
        public static bool Contain(string codigoGrupo) {
            bool output = false;
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
                            if (reader["desc_grupo"].ToString()== codigoGrupo)
                            {
                                output = true;
                            }
                        }
                    }
                }
            }
            return output;
        }
        /**
         * Esta funcion regresa el ID de un codigo grupo, en dado caso que no exista retornara
         * un valor 0 (el valor 0 no es una id valida en sqlite)
         * Sintaxis: Ctl_codigoGrupo.getID([codigoGrupo])
         * Variable: [codigoGrupo] -> string
         * Return Type: int
         **/
        public static int getId(string codigoGrupo) {
            int output = 0;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "select * from ctl_codigoGrupo where desc_grupo = @desc";
                    command.Parameters.AddWithValue("@desc", codigoGrupo);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["desc_grupo"].ToString() == codigoGrupo)
                            {
                                output = int.Parse(reader["id_codigo"].ToString());
                            }
                        }
                    }
                }
            }
            return output;
        }

        /**
         * Esta funcion añade un codigo de grupo si y solo no esta registrado este codigo antes, cuando
         * la adicion es exitosa regresa un valor verdadero, pero si el codigo ya existe no se añadira el
         * mismo codigo dos veces y regresara un valor falso.
         * Sintaxis: Ctl_codigoGrupo.add([CodigoGrupo])
         * Variables: [CodigoGrupo] -> string
         * Return type: bool
         **/
        public static bool add(string codigoGrupo)
        {
            bool output = true;
            if(!Contain(codigoGrupo))
            {
                ForceAdd(codigoGrupo);
            }
            else
            {
                output = false;
            }
            return output;
        }
        /**
         * Funcion interna, neta si no sabes que hace no lo toques
         **/
        private static void ForceAdd(string codigoGrupo)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_codigoGrupo (desc_grupo) values (@codigo_grupo)";
                    command.Parameters.AddWithValue("@codigo_grupo", codigoGrupo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
