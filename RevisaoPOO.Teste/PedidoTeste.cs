using System;
using System.Collections.Generic;
using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class PedidoTeste
    {
        private Usuario CriaUsuarioPadrao()
        {
            return new Usuario("Rafael", "rafaelargollo22@hotmail.com", "senha123");
        }

        private Produto CriaProdutoPadrao()
        {
            return new Mouse(1, "mouse", "logitech", true, "mouse gamer", 100, 5, 6000);
        }

        private List<Produto> CriaListaProdutosPadrao()
        {
            return new List<Produto>();
        }

        private Pedido CriaPedidoPadrao()
        {
            return new Pedido(CriaUsuarioPadrao(), CriaListaProdutosPadrao(), 0, "entregue", "21/03/2022");
        }

        [Fact]
        public void TesteGetUsuario()
        {
            var pedido = CriaPedidoPadrao();
            pedido.GetUsuario();
            var usuarioEsperado = CriaUsuarioPadrao();
            Assert.Equal(usuarioEsperado.Email, pedido.Usuario.Email);
        }

        [Fact]
        public void TesteGetProdutos()
        {
            var pedido = CriaPedidoPadrao();
            pedido.GetProdutos();
            var listaEsperada = CriaListaProdutosPadrao();
            Assert.Equal(listaEsperada, pedido.Produtos);
        }

        [Fact]
        public void TesteGetValorTotal()
        {
            var pedido = CriaPedidoPadrao();
            pedido.GetValorTotal();
            var valorTotalEsperado = 0;
            Assert.Equal(valorTotalEsperado, pedido.ValorTotal);
        }

        [Fact]
        public void TesteGetStatus()
        {
            var pedido = CriaPedidoPadrao();
            pedido.GetStatus();
            var statusEsperado = "entregue";
            Assert.Equal(statusEsperado, pedido.Status);
        }

        [Fact]
        public void TesteGetData()
        {
            var pedido = CriaPedidoPadrao();
            pedido.GetStatus();
            var dataEsperada = DateTime.Parse("21/03/2022");
            Assert.Equal(dataEsperada, pedido.Data);
        }

        /*
                [Fact]
                public void TesteAdicionarProduto()
                {
                    var pedido = CriaPedidoPadrao();
                    var listaProdutos = CriaListaProdutosPadrao();
                    var produto = CriaProdutoPadrao();
                    pedido.AdicionarProduto(produto);
                    var idEsperado = 1;
                    Assert.Equal(idEsperado, listaProdutos[0].ID);
                }
                */

        [Fact]
        public void TesteFinalizarPedido()
        {
            var pedido = CriaPedidoPadrao();
            var produto = CriaProdutoPadrao();
            pedido.AdicionarProduto(produto);
            var produto2 = CriaProdutoPadrao();
            pedido.AdicionarProduto(produto2);
            pedido.FinalizarPedido();
            var valorFinalEsperado = 2*((100 + (6000 / 50)) * 1.15);
            Assert.Equal(valorFinalEsperado, pedido.ValorTotal);
        }
    }
}