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
        ValorTransacao = valor;
        Console.WriteLine($"Processando pagamento de R$ {valor} no cartão de {NumeroCartao}");
        return true;
    }

    public string ObterComprovante()
    {
        return $"Comprovante Cartão: R$ {ValorTransacao}";
    }

    public void CancelarTransacao()
    {
        Console.WriteLine($"Estornando valor no cartão.");
    }
}