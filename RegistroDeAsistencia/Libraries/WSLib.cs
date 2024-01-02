using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using RegistroDeAsistencia.DataBase.Modelo;
using ScrapySharp.Extensions;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace RegistroDeAsistencia.Libraries
{
    internal static class WSLib
    {
        public static List<String> GetAlumnoFrom(string url)
        {
            List<String> output = new List<String>();

            HtmlWeb oWeb = new HtmlWeb();
            HtmlDocument document = oWeb.Load(url);
            var classBoleta = document.DocumentNode.CssSelect(".boleta").First();
           
            output.Add(classBoleta.InnerHtml);

            var classNombre = document.DocumentNode.CssSelect(".nombre").First();
            List<String> FullName = classNombre.InnerHtml.Split(' ').ToList();
            string ama = FullName[FullName.Count - 1];
            string apa = FullName[FullName.Count - 2];
            string nom = FullName[0];
            if (FullName[1] != apa) nom += " " + FullName[1];

            output.Add(nom);
            output.Add(apa);
            output.Add(ama);

            var classEscuela = document.DocumentNode.CssSelect(".escuela").First();
            output.Add(classEscuela.InnerHtml);

            var classCarrera = document.DocumentNode.CssSelect(".carrera").First();
            output.Add(classCarrera.InnerHtml);

            return output;
        }
    }
}
