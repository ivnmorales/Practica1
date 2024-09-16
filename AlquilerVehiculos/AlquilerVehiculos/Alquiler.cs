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
        private static void AdministradorMenu()
        {
            while (esAdministrador)
            {
                Console.WriteLine("--- Menú de Gestión de Vehículos ---");
                Console.WriteLine("1. Registrar nuevo vehículo");
                Console.WriteLine("2. Eliminar vehículo");
                Console.WriteLine("3. Actualizar vehículo");
                Console.WriteLine("4. Ver historial de reservas");
                Console.WriteLine("5. Mostrar vehículos");
                Console.WriteLine("6. Cambiar a Cliente");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarVehiculo();
                        break;
                    case "2":
                        EliminarVehiculo();
                        break;
                    case "3":
                        ActualizarVehiculo();
                        break;
                    case "4":
                        VerHistorialReservas();
                        break;
                    case "5":
                        MostrarVehiculos();
                        break;
                    case "6":
                        esAdministrador = false;
                        Console.WriteLine("\nCambiando a modo Cliente.\n");
                        return; // Salir del menú de administrador
                    case "7":
                        Console.WriteLine("Saliendo del programa.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
