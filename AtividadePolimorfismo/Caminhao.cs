internal class Caminhao : Veiculo
{
    public override void CalcularConsumo(double distancia)
    {
        double consumo = distancia / 6;
        Console.WriteLine($"Consumo do caminhão para {distancia} km: {consumo} litros");
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Marca: Volvo");
        Console.WriteLine("Modelo: FH16");
        Console.WriteLine("Ano: 2022");
        Console.WriteLine("Combustível: Diesel");
    }
}