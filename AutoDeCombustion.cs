using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculos.Clases
{
    public class AutoDeCombustion : Vehiculo
    {
        private int nivelCombustible = 100;

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            nivelCombustible--;
            Console.WriteLine("Nivel de combustible: {0}%", nivelCombustible);
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("Frenado realizado en el auto de combustión.");
        }

        public override void Encender()
        {
            Console.WriteLine("El auto de combustión está encendido.");
        }

        public void CargarCombustible(int cuanto)
        {
            nivelCombustible += cuanto;
            if (nivelCombustible > 100) nivelCombustible = 100;
            Console.WriteLine("Combustible cargado a {0}%", nivelCombustible);
        }
    }
}