internal class Carros : Veiculos
{
    protected int numeroDePortas;

    public Carro(string marca, string modelo, int numeroDePortas) : base(marca, modelo)
    {
        this.numeroDePortas = numeroDePortas;
    }
}