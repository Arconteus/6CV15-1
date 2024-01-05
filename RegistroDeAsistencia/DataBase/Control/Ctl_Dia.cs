using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;

namespace RegistroDeAsistencia.DataBase.Control
{
    public class Ctl_Dia
    {
        // Variables de control de la base de datos
        private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

        // Métodos públicos

        /**
         * Esta función devuelve una lista de la clase Dia, que contiene toda la lista de
         * días de la semana dados de alta.
         * Sintaxis: Ctl_Dia.GetList()
         * Return Type: List<Dia>
         **/
        public static List<Dia> GetList()
        {
            List<Dia> output = GetListWhere("");
            return output;
        }

        public static List<Dia> GetList(string extraParameters)
        {
            List<Dia> output = GetListWhere(extraParameters);
            return output;
        }

        /**
         * Esta función añade el día si y solo si no está registrado antes. Cuando la adición
         * es exitosa, devuelve un valor verdadero, pero si el día ya existe, no se añadirá el
         * mismo día dos veces y devuelve un valor falso.
         * Sintaxis: Ctl_Dia.ForceAdd([DiaInput])
         * Variables: [DiaInput] -> Dia(){desc_dia=[string]}
         * Return type: bool
         **/
        public static bool ForceAdd(Dia DiaInput)
        {
            bool output = false;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO ctl_diasSemana (desc_dia) VALUES (@desc_dia)";
                    command.Parameters.AddWithValue("@desc_dia", DiaInput.desc_dia);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        output = true;
                    }
                    command.Parameters.Clear();
                }
            }
            return output;
        }

        // Métodos privados

        /**
         * Función interna, no la toques si no sabes qué hace.
         **/
        private static List<Dia> GetListWhere(string extraParameters)
        {
            List<Dia> output = new List<Dia>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    // Filtramos los días excluyendo "Sábado" y "Domingo"
                    command.CommandText = "SELECT * FROM ctl_diasSemana WHERE desc_dia NOT IN ('SABADO', 'DOMINGO') " + extraParameters;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output.Add(new Dia()
                            {
                                id_diaSemena = int.Parse(reader["id_diaSemena"].ToString()),
                                desc_dia = reader["desc_dia"].ToString()
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
