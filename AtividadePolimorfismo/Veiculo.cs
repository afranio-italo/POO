internal abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Ano { get; set; }
    public string Combustível { get; set; }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando o veículo...");
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Combustível: {Combustível}");
    }

    public abstract void CalcularConsumo(double distancia);

    public void SimularViagem()
    {
        Console.WriteLine("Simulando viagem...");
        Acelerar();
        Console.WriteLine("Viagem concluída!");
    }
}