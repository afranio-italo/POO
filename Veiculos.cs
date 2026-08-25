internal class Veiculos
{
    protected string marca { get; set; }

    protected string modelo { get; set; }

    public Veiculos(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }
}