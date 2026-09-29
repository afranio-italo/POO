using System.Text.Json;

string WriteJSON()
{
    var weatherForecast = new WeatherForecast()
    {
        Date = DateTime.Parse("2019-08-01"),
        TemperatureCelsius = 25,
        Summary = "Hot"
    };
    var options = new JsonSerializerOptions{WriteIndented = true};
    string jsonString = JsonSerializer.Serialize(weatherForecast, options);
    //byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(weatherForecast, options);
    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) +
        "\\weatherForecast.json";
    File.WriteAllText(path, jsonString);
    //File.WriteAllBytes(path, jsonUtf8Bytes);

    return path;
}

Console.WriteLine($"Arquivo JSON salvo em: {WriteJSON()}");

void ReadJSON()
{
    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) +
        "\\weatherForecast.json";
    string jsonString = File.ReadAllText(path);
    var weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
    Console.WriteLine($"Date: {weatherForecast.Date}");
    Console.WriteLine($"TemperatureCelsius: {weatherForecast.TemperatureCelsius}");
    Console.WriteLine($"Summary: {weatherForecast.Summary}");
}
ReadJSON();
//Console.WriteLine($"Arquivo JSON salvo em: {WriteJSON()}");