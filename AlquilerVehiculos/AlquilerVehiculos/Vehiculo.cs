using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public abstract class Vehiculo : IVehiculo
    {
        //atributos que necesitamos de los vehiculos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public EstadoVehiculo Estado { get; set; }
        public List<string> HistorialReservas { get; set; } = new List<string>();

        //constructor protegido para inicializar los atributos 

        protected Vehiculo(string marca, string modelo, int año, decimal precio)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
            Estado = EstadoVehiculo.Disponible;
        }

        //metodo para alquilarle al cliente
        public void Alquilar(string cliente)
        {
            Estado = EstadoVehiculo.Alquilado; //cambia el estado a alquilado
            HistorialReservas.Add($"Alquilado a {cliente}."); 
            Console.WriteLine($"Vehículo alquilado a {cliente}.");
        }

        public void Reservar(string cliente)
        {
            Estado = EstadoVehiculo.Alquilado; // Cambia el estado a 'Alquilado'
            HistorialReservas.Add($"Reservado para {cliente}.");
            Console.WriteLine($"Vehículo reservado para {cliente}.");
        }

        public void Devolver()
        {
            Estado = EstadoVehiculo.Disponible; //cambia el estado a disponible
            Console.WriteLine("Vehículo devuelto y está disponible.");
        }

        //metodo abstracto para que las clases derivadas puedan mostrar los detalles del vehiculo
        public abstract void MostrarDetalles();

        
    }
}
