internal class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int Velocidade { get; set; }

    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Velocidade = 0;
    }

    public void LigarMotor()
    {
        Console.WriteLine("Motor Ligado!");
    }
    
    public void Acelerar()
    {
        Velocidade += 10;
    }
}