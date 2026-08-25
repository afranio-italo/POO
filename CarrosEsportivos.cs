internal class CarrosEsportivos : Carros
{
    public string Tipo { get; set; }
    public string Marca { get; set; }

    public CarrosEsportivos(string marca, string modelo, int numeroDePortas) : base(marca, modelo, numeroDePortas)
    {
        this.turbo = true
    }
}