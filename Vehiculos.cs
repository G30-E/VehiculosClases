using ProyectoVehiculos.Clases;

class Program
{
    static void Main(string[] args)
    {
        Vehiculo miCarroElectrico = new CarroElectrico();
        miCarroElectrico.Acelerar(50);
        miCarroElectrico.Frenar(20);
        ((CarroElectrico)miCarroElectrico).CargarBateria(30);

        Vehiculo miAutoDeCombustion = new AutoDeCombustion();
        miAutoDeCombustion.Acelerar(60);
        miAutoDeCombustion.Frenar(30);
        ((AutoDeCombustion)miAutoDeCombustion).CargarCombustible(20);

        Vehiculo miMotocicleta = new Motocicleta();
        miMotocicleta.Acelerar(80);
        miMotocicleta.Frenar(40);
        ((Motocicleta)miMotocicleta).UsarCasco();

        Vehiculo miCamion = new Camion();
        miCamion.Acelerar(70);
        miCamion.Frenar(50);
        ((Camion)miCamion).CargarMercancia(1000);
    }
}
