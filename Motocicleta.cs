using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculos.Clases
{
    public class Motocicleta : Vehiculo
    {
        private bool tieneCasco = true;

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            velocidad += 10;
            Console.WriteLine("Aceleraste rápidamente en la motocicleta. Nueva velocidad: {0} KMS / Hora", velocidad);
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            Console.WriteLine("Frenado realizado en la motocicleta.");
        }

        public override void Encender()
        {
            Console.WriteLine("La motocicleta está encendida.");
        }

        public void UsarCasco()
        {
            if (tieneCasco)
            {
                Console.WriteLine("Casco puesto.");
            }
            else
            {
                Console.WriteLine("No tienes casco.");
            }
        }
    }
}
