using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;
using System.Collections.Generic;

namespace RegistroDeAsistencia.DataBase.Control
{
    public static class Ctl_Horario
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        public static List<Horario> GetList()
        {
            List<Horario> output = GetListWhere("");
            return output;
        }

        public static List<Horario> GetList(string extraParameters)
        {
            List<Horario> output = GetListWhere(extraParameters);
            return output;
        }

        public static bool Contain(Horario HorarioInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "SELECT * FROM ctl_horario WHERE grupo_horario = @grupo_horario" +
                        " AND hora_horario = @hora_horario" +
                        " AND dia_horario = @dia_horario";
                    command.Parameters.AddWithValue("@grupo_horario", HorarioInput.grupo_horario);
                    command.Parameters.AddWithValue("@hora_horario", HorarioInput.hora_horario);
                    command.Parameters.AddWithValue("@dia_horario", HorarioInput.dia_horario);
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

        public static bool Add(Horario HorarioInput)
        {
            bool output = false;
            if (!Contain(HorarioInput))
            {
                output = ForceAdd(HorarioInput);
            }
            else
            {
                Hora _hora = Ctl_Hora.GetList("where id_horas = " + HorarioInput.hora_horario).First();
                Dia _dia = Ctl_Dia.GetList(" and id_diaSemena = " + HorarioInput.dia_horario).First();
                DialogResult result = MessageBox.Show("El horario "+_hora.desc_horas+" el dia "+ _dia.desc_dia + "Ya esta ocupado.",
                    "¿Desea remplazar este dia? ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return output = false;
                Horario _horario = GetList("where grupo_horario = " + HorarioInput.grupo_horario 
                    + " and hora_horario = " + HorarioInput.hora_horario 
                    + " and dia_horario = "+HorarioInput.dia_horario).First();
                Replace(HorarioInput);
            }
            return output;
        }

        public static bool Replace(Horario HorarioInput)
        {
            bool output = true;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"REPLACE INTO ctl_horario (id_horario,grupo_horario, hora_horario, dia_horario) VALUES (@id_horario,@grupo_horario, @hora_horario, @dia_horario)";

                    // Asegúrate de que grupo_horario se esté manejando correctamente como string
                    command.Parameters.AddWithValue("@id_horario", HorarioInput.id_horario);
                    command.Parameters.AddWithValue("@grupo_horario", HorarioInput.grupo_horario);
                    command.Parameters.AddWithValue("@hora_horario", HorarioInput.hora_horario);
                    command.Parameters.AddWithValue("@dia_horario", HorarioInput.dia_horario);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }


        public static bool Remove(string WhereClasuse)
        {
            bool output = true;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "DELETE FROM ctl_horario " + WhereClasuse;

                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }

                    command.Parameters.Clear();
                }
            }
            return output;
        }

        private static bool ForceAdd(Horario HorarioInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_horario (grupo_horario, hora_horario, dia_horario) VALUES (@grupo_horario, @hora_horario, @dia_horario)";

                    // Asegúrate de que grupo_horario se esté manejando correctamente como string
                    command.Parameters.AddWithValue("@grupo_horario", HorarioInput.grupo_horario);
                    command.Parameters.AddWithValue("@hora_horario", HorarioInput.hora_horario);
                    command.Parameters.AddWithValue("@dia_horario", HorarioInput.dia_horario);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }


        private static List<Horario> GetListWhere(string extraParameters)
        {
            List<Horario> output = new List<Horario>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "SELECT * FROM ctl_horario " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Horario()
                            {
                                id_horario = int.Parse(reader["id_horario"].ToString()),
                                grupo_horario = int.Parse(reader["grupo_horario"].ToString()),
                                hora_horario = int.Parse(reader["hora_horario"].ToString()),
                                dia_horario = int.Parse(reader["dia_horario"].ToString()),
                            });
                        }
                    }
                }
            }
            return output;
        }
    }
}
