using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public abstract class Vehiculo : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }
        public EstadoVehiculo Estado { get; set; }
        public List<string> HistorialReservas { get; set; } = new List<string>();

        protected Vehiculo(string marca, string modelo, int año, decimal precio)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
            Estado = EstadoVehiculo.Disponible;
        }
    }
}
