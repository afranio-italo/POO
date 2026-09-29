public class ArquivoJson : Arquivo
{
    public override void Salvar(string caminho, object objeto)
    {
        string json = JsonSerializer.Serialize(objeto);
        File.WriteAllText(caminho, json);
    }

    public override void Ler(string caminho)
    {
        string json = File.ReadAllText(caminho);
        JsonSerializer.Deserialize<WeatherForecast>(json);
    }
}