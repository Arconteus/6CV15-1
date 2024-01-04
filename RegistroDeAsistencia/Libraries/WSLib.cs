using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace RegistroDeAsistencia.Libraries
{
    internal static class WSLib
    {
        public static List<String> GetAlumnoFrom(string url)
        {
            List<String> output = new List<String>();

            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);
            var document = context.OpenAsync(url).GetAwaiter().GetResult();

            var classBoleta = document.QuerySelector(".boleta");
            output.Add(classBoleta.InnerHtml);

            var classNombre = document.QuerySelector(".nombre");
            List<String> FullName = classNombre.InnerHtml.Split(' ').ToList();
            string ama = FullName[FullName.Count - 1];
            string apa = FullName[FullName.Count - 2];
            string nom = FullName[0];
            if (FullName[1] != apa) nom += " " + FullName[1];

            output.Add(nom);
            output.Add(apa);
            output.Add(ama);

            var classEscuela = document.QuerySelector(".escuela");
            output.Add(classEscuela.InnerHtml);

            var classCarrera = document.QuerySelector(".carrera");
            string CarreraToSet = classCarrera.InnerHtml;
            //=======================================================
            // MODIFICAR POR FAVOR LA VARIABLE CarreraToSet PARA QUE
            // NO SE AGREGEN CARACTERES EXTRAÑOS.
            //=======================================================
            output.Add(CarreraToSet);

            return output;
        }
    }
}
