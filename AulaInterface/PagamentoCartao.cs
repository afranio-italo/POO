internal class PagamentoCartao : IPagamento
{
    public decimal ValorTransacao { get; private set; }
    public string NumeroCartao;
    public PagamentoCartao(string numeroCartao)
    {
        this.NumeroCartao = numeroCartao;
    }

    public bool ProcessarPagamento(decimal valor)
    {
    }

    public string ObterComprovante()
    {
    }

    public void CancelarTransacao()
    {
    }
}