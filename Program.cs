using System;
using System.Security.Cryptography.X509Certificates;
using Clases;

namespace Clases
{
    class Program
    {

        public static void RegistrarEquipo(List<Equipo> equipos)
        {
            Console.Write("Ingrese el nombre del equipo: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Ingrese la ciudad de origen: ");
            string ciudad = Console.ReadLine() ?? "";

            Equipo nuevo = new Equipo(nombre, ciudad);
            equipos.Add(nuevo);
        }


            static void Main(string[] args)
        {

            List<Equipo> listaEquipos = new List<Equipo>();
            


            Console.Clear();
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Registrar equipo.");
            Console.WriteLine("2. Ver equipos.");
            Console.WriteLine("3. Jugar partido.");
            Console.WriteLine("4. Ver tabla de posiciones.");
            Console.WriteLine("5. Ver historial de partidos.");
            Console.WriteLine("6. Salir.");

            string opcionSelect = Console.ReadLine();

            bool salir = false;
            while (!salir)
            {


                switch (opcionSelect)
                {
                    case "1":
                        RegistrarEquipo(listaEquipos);
                        break;

                    case "2":
                        Tabla.VerEquipos();
                        break;
                    case "3":
                        return;
                    case "4":
                        Tabla.ObtenerPosiciones();
                        break;
                    case "5":
                        Historial.VerHistorial();
                        return;
                    case "6":
                        Console.WriteLine("Saliendo...");
                        salir = true;
                        break;





                }
            }






        }

    }
}