using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculos.Clases
{
    public class CarroElectrico : Vehiculo
    {
        private int cargaBateria = 100;

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            cargaBateria--;
            Console.WriteLine("Carga de batería: {0}%", cargaBateria);
        }

        public override void Encender()
        {
            Console.WriteLine("El carro eléctrico está encendido.");
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("Frenado realizado en el carro eléctrico.");
        }

        public void CargarBateria(int cuanto)
        {
            cargaBateria += cuanto;
            if (cargaBateria > 100) cargaBateria = 100;
            Console.WriteLine("Batería cargada a {0}%", cargaBateria);
        }
    }
}
