void Main()
{
    Cachorro cachorro = new Cachorro();
    cachorro.Nome = "Rex";

    Passaro passaro = new Passaro();
    passaro.Nome = "Golinha";

    cachorro.FazerSom();
    passaro.FazerSom();

    cachorro.Mover();
    passaro.Mover();
}

Main();