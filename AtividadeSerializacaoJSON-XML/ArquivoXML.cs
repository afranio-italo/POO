public class ArquivoXML : Arquivo
{
    public override void Salvar(string caminho, object objeto)
    {
        XmlSerializer serializer = new XmlSerializer(objeto.GetType());
        using (StreamWriter writer = new StreamWriter(caminho))
        {
            serializer.Serialize(writer, objeto);
        }
    }

    public override void Ler(string caminho)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(WeatherForecast));
        using (StreamReader reader = new StreamReader(caminho))
        {
            return serializer.Deserialize(reader);
        }
    }
}