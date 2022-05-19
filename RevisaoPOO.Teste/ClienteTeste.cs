using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class ClienteTeste
    {
        private Cliente CriaClientePadrao()
        {
            return new Cliente("Rafael", "rafaelargollo22@hotmail.com", "senha123", "12345678978", "iguaçaba");
        }

        [Fact]
        public void TesteGetCPF()
        {
            var cliente = CriaClientePadrao();
            cliente.GetCPF();
            var CpfEsperado = "12345678978";
            Assert.Equal(CpfEsperado, cliente.CPF);
        }

         [Fact]
        public void TesteGetEndereco()
        {
            var cliente = CriaClientePadrao();
            cliente.GetEndereco();
            var enderecoEsperado = "iguaçaba";
            Assert.Equal(enderecoEsperado, cliente.Endereco);
        }
    }
}