var pagCart = new PagamentoCartao();
pagCart.ProcessarPagamento(100);
console.WriteLine(pagCart.ObterComprovante());