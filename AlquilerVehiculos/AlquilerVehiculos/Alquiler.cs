﻿using System;
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

        private static void ClienteMenu()
        {
            while (!esAdministrador)
            {
                Console.WriteLine("--- Menú de Cliente ---");
                Console.WriteLine("1. Reservar vehículo");
                Console.WriteLine("2. Devolver vehículo");
                Console.WriteLine("3. Mostrar vehículos");
                Console.WriteLine("4. Cambiar a Administrador");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ReservarVehiculo();
                        break;
                    case "2":
                        DevolverVehiculo();
                        break;
                    case "3":
                        MostrarVehiculos();
                        break;
                    case "4":
                        esAdministrador = true;
                        Console.WriteLine("\nCambiando a modo Administrador.\n");
                        return; // Salir del menú de cliente
                    case "5":
                        Console.WriteLine("Saliendo del programa.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        private static void RegistrarVehiculo()
        {
            Console.Write("Ingrese la marca del vehículo: ");
            var marca = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehículo: ");
            var modelo = Console.ReadLine();
            Console.Write("Ingrese el año del vehículo: ");
            var año = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio de alquiler del vehículo: ");
            var precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué tipo de vehículo desea registrar?");
            Console.WriteLine("1. Automóvil");
            Console.WriteLine("2. Motocicleta");
            Console.WriteLine("3. Camión");
            Console.Write("Ingrese una opción: ");
            var tipo = Console.ReadLine();

            Vehiculo vehiculo = tipo switch
            {
                "1" => new Automovil(marca, modelo, año, precio),
                "2" => new Motocicleta(marca, modelo, año, precio),
                "3" => new Camion(marca, modelo, año, precio),
                _ => null
            };

            if (vehiculo != null)
            {
                vehiculos.Add(vehiculo);
                Console.WriteLine("Vehículo registrado con éxito.");
            }
            else
            {
                Console.WriteLine("Tipo de vehículo no válido. No se registró el vehículo.");
            }
        }
        private static void EliminarVehiculo()
        {
            Console.Write("Ingrese la marca del vehículo a eliminar: ");
            var marca = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehículo a eliminar: ");
            var modelo = Console.ReadLine();

            var vehiculo = vehiculos.FirstOrDefault(v => v.Marca.Equals(marca, StringComparison.OrdinalIgnoreCase) &&
                                                          v.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));

            if (vehiculo != null)
            {
                vehiculos.Remove(vehiculo);
                Console.WriteLine("Vehículo eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }

    }
}
