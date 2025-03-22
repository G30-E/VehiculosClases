using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculos.Clases
{
    public class Camion : Vehiculo
    {
        private int cargaMaxima = 5000;

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            Console.WriteLine("El camión aceleró con carga máxima.");
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("Frenado realizado en el camión.");
        }

        public override void Encender()
        {
            Console.WriteLine("El camión está encendido.");
        }

        public void CargarMercancia(int cuanto)
        {
            cargaMaxima -= cuanto;
            if (cargaMaxima < 0) cargaMaxima = 0;
            Console.WriteLine("Carga restante en el camión: {0} Kg", cargaMaxima);
        }
    }
}