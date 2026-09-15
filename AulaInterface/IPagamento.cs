internal IPagamento
{
    decimal ValorTransacao { get; }

    bool ProcessarPagamento(decimal valor);

    string ObterComprovante();

    void CancelarTransacao();
}