internal class Moto : Veiculo
{
    public override void CalcularConsumo(double distancia)
    {
        double consumo = distancia / 35;
        Console.WriteLine($"Consumo da moto para {distancia} km: {consumo} litros");
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Marca: Suzuki");
        Console.WriteLine("Modelo: VFR750");
        Console.WriteLine("Ano: 2020");
        Console.WriteLine("Combustível: Gasolina");
    }
}