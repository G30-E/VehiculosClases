using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVehiculos.Clases
{
    public class Vehiculo
    {
        protected int velocidad = 0;

        public virtual void Acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
        }

        public virtual void Frenar(int cuanto)
        {
            velocidad -= cuanto;
            if (velocidad < 0)
            {
                velocidad = 0;
            }
            Console.WriteLine("Frenaste. Ahora vas a {0} KMS / Hora", velocidad);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo está encendido.");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("El vehículo está apagado.");
        }
    }
}