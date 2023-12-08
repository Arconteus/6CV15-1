using RegistroDeAsistencia.DataBase.Control;

namespace RegistroDeAsistencia
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DataBaseHelper.InitializeDatabase();
            Ctl_codigoGrupo.addCodigoGrupo("6CV15");
            Application.Run(new Test());
        }
    }
}