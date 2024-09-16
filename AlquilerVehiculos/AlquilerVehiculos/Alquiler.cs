using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class Alquiler
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>();
        private static bool esAdministrador = false;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione su rol:");
                Console.WriteLine("1. Administrador");
                Console.WriteLine("2. Cliente");
                Console.Write("Ingrese una opción: ");
                var rol = Console.ReadLine();

                if (rol == "1")
                {
                    esAdministrador = true;
                    Console.WriteLine("\nInicio de sesión como Administrador.\n");
                    AdministradorMenu();
                }
                else if (rol == "2")
                {
                    esAdministrador = false;
                    Console.WriteLine("\nInicio de sesión como Cliente.\n");
                    ClienteMenu();
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }
    }
}
