using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Partido
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public DateTime Fecha { get; set; }

        public int GolesLocal;
        public int GolesVisitante;

        public Partido (Equipo local, Equipo visitante) 
        {
            this.Local = local;
            this.Visitante = visitante;
            Fecha = DateTime.Now;
        }

        //mostrar en pantalla que equipo fue el que ganó el partido.
        public string Resultado()
        {
            if (GolesLocal > GolesVisitante) return $"{Local.Nombre} ganó";
            else if (GolesLocal < GolesVisitante) return $"return {Visitante.Nombre} ganó";
            else return "Empate";
        }


    }
}
