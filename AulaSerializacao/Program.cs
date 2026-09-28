using System.Xml.Serialization;

string WriteXML()
{
    List<Book> livros = new List<Book>()
    {
        new Book() { Title = "Harry Potter 1" },
        new Book() { Title = "Harry Potter 2" },
        new Book() { Title = "Harry Potter 3" },
    };
    // Book livro = new Book()
    // {
    //     Title = "Harry Potter 1"
    // };
    // Prepara objeto serializador:
    XmlSerializer writer = new XmlSerializer(typeof(List<Book>));
    //Prepara o arquivo XML para gravar no disco:
    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) + "\\livros.xml";
    FileStream arquivoXML = File.Create(path);
    // Realiza a serialização e gravação no disco:
    writer.Serialize(arquivoXML, livros);
    arquivoXML.Close();
    return path;
}

void ReadXML()
{
    try
    {
    // Prepara objeto serializador:
    XmlSerializer reader = new XmlSerializer(typeof(List<Book>));
    //Prepara o arquivo XML
    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) + "\\livros.xml";
    StreamReader arquivoXML = new StreamReader(path);
        // Deserialização do XML para objeto:
        List<Book> livros = (List<Book>)reader.Deserialize(arquivoXML);
        foreach (var livro in livros)
        {
            Console.WriteLine($"Livro: {livro.Title}");
        }
        arquivoXML.Close();
    }
    catch (System.IO.FileNotFoundException)
    {
        Console.WriteLine("Arquivo não encontrado.");
    }
    finally
    {
        Console.WriteLine("Fim da leitura do arquivo XML.");
    }
}

// string caminhoDoArquivo = WriteXML();
// Console.WriteLine($"Arquivo XML criado em: {caminhoDoArquivo}");
ReadXML();
