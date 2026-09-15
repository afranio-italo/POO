internal class Carro : Veiculo, IManutencao, ISeguranca
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

    public void RealizarRevisao()
    {
        Console.WriteLine("Realizando revisão do carro...");
    }

    public void TrocarOleo()
    {
        Console.WriteLine("Óleo do carro trocado...");
    }

    public void AtivarAlarme()
    {
        Console.WriteLine("Ativando alarme do carro...");
    }

    public void TravarPortas()
    {
        Console.WriteLine("Travando portas do carro...");
    }
}