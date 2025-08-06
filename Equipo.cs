namespace Clases

{
    public class Equipo
    {
        
        public string Nombre;
        public string Ciudad;

        public int GolesAFavor;
        public int GolesEnContra;
        public int Puntos;


        public Equipo (string nombre, string ciudad)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.GolesAFavor = 0;
            this.GolesEnContra = 0;
            this.Puntos = 0;
        }
    }
}