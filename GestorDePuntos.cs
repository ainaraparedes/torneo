using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //asignar puntos a los equipos de acuerdo a los goles realizados.
    public class GestorDePuntos
    {
        public void AsignarPuntos(Equipo local, Equipo visitante, int golesLocal, int golesVisitante)
        {
            local.GolesAFavor += golesLocal;
            local.GolesEnContra += golesVisitante;

            visitante.GolesAFavor += golesVisitante;
            visitante.GolesEnContra += golesLocal;

            if (golesLocal > golesVisitante)
            { local.Puntos += 3; }
            else if (golesLocal == golesVisitante)
            { local.Puntos += 1; visitante.Puntos += 1; }
            else { visitante.Puntos += 3; }
        }


    } 


}
