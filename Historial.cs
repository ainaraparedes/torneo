using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Historial
    {

        //guarda los partidos concretados dentro de una lista.
        public List<Partido> Partidos = new List<Partido>();
        public void RegistrarPartido(Partido partido)
        {
            Partidos.Add(partido);
        }
        //muestra en pantalla el historial de partidos jugados.
        public List<Partido> VerHistorial()
        {
            return Partidos;
        }

    }
}
