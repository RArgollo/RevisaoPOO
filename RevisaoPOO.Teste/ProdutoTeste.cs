using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class ProdutoTest
    {
        private Produto CriaProdutoPadrao()
        {
            return new Produto(1, "mouse", "logitech", true, "mouse gamer", 100, 5);
        }

        [Fact]
        public void TesteGetNome()
        {
            var produto = CriaProdutoPadrao();
            produto.GetNome();
            var nomeEsperado = "mouse";
            Assert.Equal(nomeEsperado, produto.Nome);
        }

        [Fact]
        public void TesteGetID()
        {
            var produto = CriaProdutoPadrao();
            produto.GetID();
            var idEsperado = 1;
            Assert.Equal(idEsperado, produto.ID);
        }

        [Fact]
        public void TesteGetMarca()
        {
            var produto = CriaProdutoPadrao();
            produto.GetMarca();
            var marcaEsperada = "logitech";
            Assert.Equal(marcaEsperada, produto.Marca);
        }

        [Fact]
        public void TesteGetDescricao()
        {
            var produto = CriaProdutoPadrao();
            produto.GetDescricao();
            var descricaoEsperada = "mouse gamer";
            Assert.Equal(descricaoEsperada, produto.Descricao);
        }

        [Fact]
        public void TesteGetValor()
        {
            var produto = CriaProdutoPadrao();
            produto.GetValor();
            var valorEsperado = 100;
            Assert.Equal(valorEsperado, produto.Valor);
        }

        [Fact]
        public void TesteGetEstoque()
        {
            var produto = CriaProdutoPadrao();
            produto.GetEstoque();
            var estoqueEsperado = 5;
            Assert.Equal(estoqueEsperado, produto.Estoque);
        }

        [Fact]
        public void TesteAdicionarEstoque()
        {
            var produto = CriaProdutoPadrao();
            produto.AdicionarEstoque(2);
            var estoqueEsperado = 7;
            Assert.Equal(estoqueEsperado, produto.Estoque);
        }

        [Fact]
        public void TesteRemoverEstoque()
        {
            var produto = CriaProdutoPadrao();
            produto.RemoverEstoque(2);
            var estoqueEsperado = 3;
            Assert.Equal(estoqueEsperado, produto.Estoque);
        }
    }
}