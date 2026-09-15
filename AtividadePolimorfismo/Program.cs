void UsarFrota(Veiculo[] frota)
{
    foreach (var veiculo in frota)
    {
        veiculo.ExibirInfo();
        double distancia = 100;
        double consumo = veiculo.CalcularConsumo(distancia);
        console.WriteLine($"Consumo do veículo para {distancia} km: {consumo} litros");
        veiculo.acelerar();
    }
}


void Main()
{
 Veiculo[] frota =
{
        new caminhao { Marca = "Volvo", Modelo = "FH16", Ano = "2023", Combustível = "Diesel" },
        new Carro { Marca = "Honda", Modelo = "Civic", Ano = "2020", Combustível = "Gasolina" },
        new Moto { Marca = "Yamaha", Modelo = "R1", Ano = "2022", Combustível = "Gasolina" }
};
}