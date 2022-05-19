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

        private List<Produto> CriaListaProdutosPadrao()
        {
            return new List<Produto>();
        }

        private Pedido CriaPedidoPadrao()
        {
            return new Pedido(CriaUsuarioPadrao(), CriaListaProdutosPadrao(), 200, "entregue", "21/03/2022");
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
            var valorTotalEsperado = 200;
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

    }
}