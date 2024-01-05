using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
using System.Configuration;
using System.Data.SQLite;
using System.Security.AccessControl;
public static class DataBaseHelper
{
    //==============================================
    // Variables de control de la base de datos
    //==============================================
    private static string connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
    private static string rootDataBase = ConfigurationManager.ConnectionStrings["rootDataBase"].ConnectionString;
    private static string structureScriptPath = ConfigurationManager.ConnectionStrings["structureScriptPath"].ConnectionString;
    //==============================================
    // Metodos de inicializacion de base de datos
    //==============================================
    /**
     * Esta funcion inicializa la base de datos si es que no existe.
     * Las rutas estan establecidad en el app.condif. No regresa ningun
     * tipo de dato.
     **/
    public static void InitializeDatabase()
    {
        if (!File.Exists(rootDataBase))
        {
            SQLiteConnection.CreateFile(rootDataBase);
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = File.ReadAllText(structureScriptPath);
                    command.ExecuteNonQuery();
                }
            }
            Preset();
        }
    }
    private static void Preset()
    {
        InitializeCodigoGrupo();
        InitializeMaterias();
        InitializeProfesors();
        InitializeEscuelas();
        InitializeCarreras();
        InitializeTimeThings();
    }

    private static void InitializeTimeThings()
    {
        List<string> DiasSemanaToAdd = new List<string>();
        DiasSemanaToAdd.Add("LUNES");
        DiasSemanaToAdd.Add("MARTES");
        DiasSemanaToAdd.Add("MIERCOLES");
        DiasSemanaToAdd.Add("JUEVES");
        DiasSemanaToAdd.Add("VIERNES");
        DiasSemanaToAdd.Add("SABADO");
        DiasSemanaToAdd.Add("DOMINGO");

        foreach(string iteration in DiasSemanaToAdd)
        {
            Ctl_Dia.ForceAdd(new Dia() { desc_dia = iteration });
        }

        List<string> HorasToAdd = new List<string>();
        HorasToAdd.Add("07:00");
        HorasToAdd.Add("08:30");
        HorasToAdd.Add("10:00");
        HorasToAdd.Add("11:30");
        HorasToAdd.Add("13:00");
        HorasToAdd.Add("14:30");
        HorasToAdd.Add("16:00");
        HorasToAdd.Add("17:30");
        HorasToAdd.Add("19:00");
        HorasToAdd.Add("20:30");
        HorasToAdd.Add("22:00");

        foreach(string iteration in  HorasToAdd)
        {
            Ctl_Hora.ForceAdd(new Hora() { desc_horas = iteration });
        }

    }
    private static void InitializeCodigoGrupo()
    {
        if (!Ctl_CodigoGrupo.Contain(new CodigoGrupo() { desc_grupo = "Sin codigo" }))
        {
            Ctl_CodigoGrupo.Add(new CodigoGrupo() { desc_grupo = "Sin codigo" });
        }

        for (int i = 1; i < 9; i++)
        {
            for (int j = 1; j < 4; j++)
            {
                for (int k = 1; k < 7; k++)
                {
                    //===================================================================================
                    string codigoMatutino = i + "CV" + j + k;
                    if (!Ctl_CodigoGrupo.Contain(new CodigoGrupo() { desc_grupo = codigoMatutino }))
                    {
                        Ctl_CodigoGrupo.Add(new CodigoGrupo() { desc_grupo = codigoMatutino });
                    }
                    //===================================================================================
                    string codigoVespertino = i + "CM" + j + k;
                    if (!Ctl_CodigoGrupo.Contain(new CodigoGrupo() { desc_grupo = codigoVespertino }))
                    {
                        Ctl_CodigoGrupo.Add(new CodigoGrupo() { desc_grupo = codigoVespertino });
                    }
                    //===================================================================================
                }
            }
        }
    }
    private static void InitializeMaterias()
    {
        List<String> MateriasToAdd = new List<string>();
        MateriasToAdd.Add("HORA LIBRE");
        //=====================================================================
        MateriasToAdd.Add("FUNDAMENTOS DE PROGRAMACION");
        //=====================================================================
        MateriasToAdd.Add("PROGRAMACION ORIENTADA A OBJETOS");
        //=====================================================================
        MateriasToAdd.Add("CIRCUITOS DE CA Y CD");
        MateriasToAdd.Add("ESTRUCTURA DE DATOS");
        MateriasToAdd.Add("LENGUAJES DE BAJO NIVEL");
        //=====================================================================
        MateriasToAdd.Add("ANALISIS NUMERICO");
        MateriasToAdd.Add("TEORIA DE AUTOMATAS");
        //=====================================================================
        MateriasToAdd.Add("ANALISIS DE ALGORITMOS");
        MateriasToAdd.Add("COMPILADORES");
        //=====================================================================
        MateriasToAdd.Add("INGENIERA DE SOFTWARE");
        MateriasToAdd.Add("SISTEMAS OPERATIVOS");
        //=====================================================================
        MateriasToAdd.Add("BASES DE DATOS");
        MateriasToAdd.Add("NUEVAS TECNOLOGIAS EN LA TRANSFERENCIA DE LA INFORMACION");
        MateriasToAdd.Add("TEORIA DE LA INFORMACION Y CODIFICACION");
        //=====================================================================

        foreach (String iteration in MateriasToAdd)
        {
            if (!Ctl_Materias.Contain(new Materia() { nom_materia = iteration }))
            {
                Ctl_Materias.Add(new Materia() { nom_materia = iteration });
            }
        }
    }
    private static void InitializeProfesors()
    {
        if (!Ctl_Profesor.Contain(new Profesor() { num_trabajador = "0" }))
        {
            Ctl_Profesor.Add(
                new Profesor()
                {
                    num_trabajador = "0",
                    nom_profesor = "Sin profesor",
                    ama_profesor = "-",
                    apa_profesor = "-"
                }
            );
        }
    }
    private static void InitializeEscuelas()
    {
        List<string> EscuelasToAdd = new List<string>();

        EscuelasToAdd.Add("ESCUELA SUPERIOR DE INGENIERIA MECANICA Y ELECTRICA UNIDAD CULHUACAN");

        foreach(string iteration in EscuelasToAdd)
        {
            if(!Ctl_Escuela.Contain(new Escuela() { nom_escuela = iteration }))
            {
                Ctl_Escuela.Add(new Escuela() { nom_escuela = iteration });
            }
        }
    }
    private static void InitializeCarreras()
    {
        List<string> CarrerasToAdd = new List<string>();

        CarrerasToAdd.Add("INGENIERIA EN COMPUTACION");
        CarrerasToAdd.Add("INGENIERIA EN COMUNICACIONES Y ELECTRONICA");
        CarrerasToAdd.Add("INGENIERIA EN SISTEMAS AUTOMOTRICES");
        CarrerasToAdd.Add("INGENIERIA MECANICA");

        foreach (string iteration in CarrerasToAdd)
        {
            if (!Ctl_Carrera.Contain(new Carrera() { nom_carrera = iteration }))
            {
                Ctl_Carrera.Add(new Carrera() { nom_carrera = iteration });
            }
        }
    }
}