using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class Camion : Vehiculo, IVehiculo
    {
        public Camion(string marca, string modelo, int año, decimal precio)
          : base(marca, modelo, año, precio)
        { }
        public override void MostrarDetalles()
        {
            Console.WriteLine($"Camión - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Precio: {Precio:C}, Estado: {Estado}");
        }
    }
}
