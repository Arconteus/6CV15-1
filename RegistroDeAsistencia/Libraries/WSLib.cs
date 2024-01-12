using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;

namespace RegistroDeAsistencia.Libraries
{
    internal static class WSLib
    {
        public static Alumno GetAlumnoFrom(string url)
        {
            if (!url.Contains("https://servicios.dae.ipn.mx/vcred/")) return null;

            Alumno output = new Alumno();

            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);
            var document = context.OpenAsync(url).GetAwaiter().GetResult();

            var classBoleta = document.QuerySelector(".boleta");
            output.boleta = classBoleta.InnerHtml;

            var classNombre = document.QuerySelector(".nombre");
            List<String> FullName = classNombre.InnerHtml.Split(' ').ToList();
            string ama = FullName[FullName.Count - 1];
            string apa = FullName[FullName.Count - 2];
            string nom = FullName[0];
            if (FullName[1] != apa) nom += " " + FullName[1];

            output.nom_alumno = nom;
            output.apa_alumno = apa;
            output.ama_alumno = ama;

            Escuela _escuela = new Escuela();
            var classEscuela = document.QuerySelector(".escuela");
            if(Ctl_Escuela.GetList("where nom_escuela = '" + classEscuela.InnerHtml+"'").Count > 0)
            {
                 _escuela = Ctl_Escuela.GetList("where nom_escuela = '" + classEscuela.InnerHtml+ "'").First();
            }
            else
            {
                Ctl_Escuela.Add(new Escuela() { nom_escuela = classEscuela.InnerHtml });
                 _escuela = Ctl_Escuela.GetList("where nom_escuela = '" + classEscuela.InnerHtml+"'").First();
            }
            output.escuela_alumno = _escuela.id_escuela;

            var classCarrera = document.QuerySelector(".carrera");

            Carrera _carrera = new Carrera();
            if (Ctl_Carrera.GetList("where nom_carrera = '"+classCarrera.InnerHtml+"'").Count > 0)
            {
                _carrera = Ctl_Carrera.GetList("where nom_carrera = '"+classCarrera.InnerHtml+"'").First();
            }
            else
            {
                Ctl_Carrera.Add(new Carrera() { nom_carrera = classCarrera.InnerHtml });
                _carrera = Ctl_Carrera.GetList("where nom_carrera = '"+classCarrera.InnerHtml+"'").First();
            }
            output.carrera_alumno = _carrera.id_carrera;

            return output;
        }
    }
}
