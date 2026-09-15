internal class Carro : Veiculo
{
    public override void CalcularConsumo(double distancia)
    {
        double consumo = distancia / 12;
        Console.WriteLine($"Consumo do carro para {distancia} km: {consumo} litros");
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Marca: Toyota");
        Console.WriteLine("Modelo: Corolla");
        Console.WriteLine("Ano: 2021");
        Console.WriteLine("Combustível: Gasolina");
    }
}