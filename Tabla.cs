using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tabla
    {


        //guarda en forma de lista los equipos registrados en el sistema.
        public List<Equipo> Equipos = new List<Equipo>();
        
        public void RegistrarEquipo(Equipo equipo)
        {
            Equipos.Add(equipo);
        }

        public List<Equipo> VerEquipos()
        {
            return Equipos;
        }

        //muestra en pantalla la lista de equipos segun sus puntos de forma descendente.
        public List<Equipo> ObtenerPosiciones (List<Equipo> equipos)
        {
            return equipos
                .OrderByDescending(e => e.Puntos)
                .ToList();
        }
    }
}
