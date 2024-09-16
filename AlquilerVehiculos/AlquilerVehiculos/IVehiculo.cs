using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        int Año { get; set; }
        decimal Precio { get; set; }
        EstadoVehiculo Estado { get; set; }
        List<string> HistorialReservas { get; set; }

        void Alquilar(string cliente);
        void Reservar(string cliente);
        void Devolver();

    }
}
