using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("Escolha o tipo de arquivo para salvar os dados:");
Console.WriteLine("1 - JSON");
Console.WriteLine("2 - XML");
string opcao = Console.ReadLine();

if (opcao == "1")
{
    var weatherForecast = new WeatherForecast()
    {
        Date = DateTime.Parse("2019-08-29"),
        TemperatureCelsius = 3,
        Summary = "Frio"
    };
    var options = new JsonSerializerOptions { WriteIndented = true };
    string jsonString = JsonSerializer.Serialize(weatherForecast, options);
    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) +
    "\\weatherForecast.json";
    File.WriteAllText(path, jsonString);

    caminhoDoArquivo = WriteJSON();
    Console.WriteLine($"Arquivo JSON salvo em: {caminhoDoArquivo}");
}
else if (opcao == "2")
{
    var weatherForecast = new WeatherForecast()
    {
        Date = DateTime.Parse("2019-08-29"),
        TemperatureCelsius = 3,
        Summary = "Frio"
    };
    XmlSerializer serializer = new XmlSerializer(typeof(WeatherForecast));
    var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\weatherForecast.xml";
    using (StreamWriter writer = new StreamWriter(path))
    {
        serializer.Serialize(writer, weatherForecast);
    }

    caminhoDoArquivo = WriteXML();
    Console.WriteLine($"Arquivo XML salvo em: {caminhoDoArquivo}");
}
else
{
    Console.WriteLine("Opção inválida.");
}