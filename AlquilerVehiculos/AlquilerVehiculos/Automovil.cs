using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class Automovil : Vehiculo, IVehiculo
    {
        //Constructor de la clase
        public Automovil(string marca, string modelo, int año, decimal precio)
            : base(marca, modelo, año, precio)
        { }

        //Implementacion del metodo abstracto MostrarDetalles de la clase Vehiculo
        public override void MostrarDetalles()
        {
            Console.WriteLine($"Automóvil - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Precio: {Precio:C}, Estado: {Estado}");
        }
    }
}
